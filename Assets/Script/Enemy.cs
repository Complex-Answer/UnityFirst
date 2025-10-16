using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _setTakeDamage = 3f; //�ִ� �浹 Ƚ��
    [SerializeField] private float _moveSpeed;
    [SerializeField] private GameObject _obj;
    private float _takeDamage;
    Rigidbody _rigidbody;
    Collider _collider;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _collider = GetComponent<Collider>();
        Init();
    }
    private void Init()
    {
        _takeDamage = _setTakeDamage; //�浹 Ƚ�� �ʱ�ȭ
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        EnemyMove();
    }


    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "Player") //���� �÷��̾�� �浹 �� ��
        {
            gameObject.SetActive(false);
            Debug.Log("�÷��̾�� �浹");
        }
        if(collision.gameObject.layer == 11)
        {
            gameObject.SetActive(false);
            Debug.Log("�����Ÿ� �̻� �Ѿ�� �����");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerBullet") //���� �Ҹ��̶� �浹 �� ��
        {
            TakeDamage();
            Debug.Log("����� ����! ���� ü��: " + _takeDamage);
        }
    }

    private void EnemyMove()
    {
        transform.position += Vector3.back * _moveSpeed * Time.deltaTime;
        

    }

    private void TakeDamage()
    {
        _takeDamage--;
        if (_takeDamage <= 0)
        {
            gameObject.SetActive(false);
        }
    }

}

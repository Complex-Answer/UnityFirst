using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _setTakeDamage = 3f; //최대 충돌 횟수
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
        _takeDamage = _setTakeDamage; //충돌 횟수 초기화
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        EnemyMove();
    }


    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "Player") //만약 플레이어와 충돌 할 시
        {
            gameObject.SetActive(false);
            Debug.Log("플레이어랑 충돌");
        }
        if(collision.gameObject.layer == 11)
        {
            gameObject.SetActive(false);
            Debug.Log("일정거리 이상 넘어가서 사라짐");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerBullet") //만약 불릿이랑 충돌 할 시
        {
            TakeDamage();
            Debug.Log("대미지 입음! 남은 체력: " + _takeDamage);
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

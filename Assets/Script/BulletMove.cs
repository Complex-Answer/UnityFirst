using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] float _BulletSpeed = 5;
    Collider _bulletCollider;


    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.tag == "Enemy")
    //    {
    //       gameObject.SetActive(false);
    //    }
       
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 11)
        {
            gameObject.SetActive(false);
            Debug.Log("일정거리 이상 넘어가서 사라짐");
        }
        if (other.gameObject.tag == "Enemy")
        {
            gameObject.SetActive(false);
        }
    }
    
    
    void Start()
    {
        _bulletCollider = GetComponent<Collider>();
    }

    
    void Update()
    {
        MoveBullet();
                
    }
    void MoveBullet()
    {
        transform.position += Vector3.forward * _BulletSpeed * Time.deltaTime;
    }
}

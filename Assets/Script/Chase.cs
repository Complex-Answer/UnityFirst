using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    [SerializeField] GameObject _target;
    [SerializeField] float _speed;
    void Update()
    {
        ChaseTarget();
    }

    void ChaseTarget()
    {
        transform.LookAt(_target.transform);
    }
}

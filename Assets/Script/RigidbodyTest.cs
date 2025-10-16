using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyTest : MonoBehaviour
{
    [SerializeField] private float _velocityValue;
    [SerializeField] private float _force = 5.0f;
    private Rigidbody _regidbody;
    private void Awake()
    {
        Init();
    }
    private void Init()
    {
        _regidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            _regidbody.AddForce((Vector3.up) * _force, ForceMode.Impulse);
        }
       
    }





}
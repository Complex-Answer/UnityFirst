using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputComp))]
public class MoveComp : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 20;
    [SerializeField] private GameObject _movingPlane;
    [SerializeField] private float _xBoundValue = 2f;
    [SerializeField] private float _zBoundValue = 3f;

    private InputComp _inputComponent;
    private Vector3 _minWorlaBounds;
    private Vector3 _maxWorlaBounds;
    private Vector3 _playerExtents;
    private void Start()
    {
        MoveComponent();
    }

    private void MoveComponent()
    {
        _inputComponent = GetComponent<InputComp>();
        SphereCollider playerColider = GetComponent<SphereCollider>();


        if (playerColider != null)
        {
            _playerExtents = playerColider.bounds.extents;
        }

        if (_movingPlane != null)
        {
            Bounds planeBounds = _movingPlane.GetComponent<MeshRenderer>().bounds;

            _minWorlaBounds = planeBounds.center - planeBounds.extents;
            _maxWorlaBounds = planeBounds.center + planeBounds.extents;
        }
    }
    private void Update()
    {
        Move();
    }
    private void Move()
    {
        if (GameManger.Instance.IsPlaying == false)
        {
            return;
        }


        Vector3 inputVec = new Vector3(_inputComponent.HorInput, 0f, _inputComponent.VerInput).normalized;
        Vector3 deltaMove = inputVec * _moveSpeed * Time.deltaTime;
        Vector3 nextPosition = transform.position + deltaMove;


        float xGap = _xBoundValue * _playerExtents.x;
        float zGap = _zBoundValue * _playerExtents.z;

        nextPosition.x = Mathf.Clamp(nextPosition.x, _minWorlaBounds.x + xGap, _maxWorlaBounds.x - xGap);
        nextPosition.z = Mathf.Clamp(nextPosition.z, _minWorlaBounds.z + zGap, _maxWorlaBounds.z - zGap);

        transform.position = nextPosition;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointMover : MonoBehaviour
{
    //�̵��ӵ� ����
    [SerializeField] private float _moveSpeed;
    //��������Ʈ � ���ִ���?
    private int _currentTargetIndex = 0;
    //��������Ʈ�� ���� Ʈ���� ��
    private Transform _wayPointBox;
    public void SetWayPointBox(Transform waypointBox)
    {
        _wayPointBox = waypointBox;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WaypointChecker"))
        {
            //����ó��
            if(_wayPointBox == null)
            {
                return;
            }

            //Ÿ���̵�
            _currentTargetIndex += 1;
            if(_currentTargetIndex >= _wayPointBox.childCount)
            {
                _currentTargetIndex = 0;
            }
        }
    }
    // Update is called once per frame
    private void Update()
    {
        MoveObj();
    }
    private void MoveObj()
    {
        //�̵��� ��������Ʈ�� ������ �ٷ� ����
        if(_wayPointBox == null)
        {
            return;
        }
        //���� �������ϴ� ������ ����
        Transform targetTrf = _wayPointBox.GetChild(_currentTargetIndex);
        // �� ������ �������� �̵��ؾ��� ������ ���
        Vector3 direction = (targetTrf.position - transform.position).normalized;
        // ������ ��������� �ű�� �̵�
        transform.position += direction*_moveSpeed * Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointMover : MonoBehaviour
{
    //이동속도 설정
    [SerializeField] private float _moveSpeed;
    //웨이포인트 몇에 와있는지?
    private int _currentTargetIndex = 0;
    //웨이포인트를 담을 트랜스 폼
    private Transform _wayPointBox;
    public void SetWayPointBox(Transform waypointBox)
    {
        _wayPointBox = waypointBox;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WaypointChecker"))
        {
            //예외처리
            if(_wayPointBox == null)
            {
                return;
            }

            //타겟이동
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
        //이동할 웨이포인트가 없으면 바로 종료
        if(_wayPointBox == null)
        {
            return;
        }
        //현재 가고자하는 지점의 정보
        Transform targetTrf = _wayPointBox.GetChild(_currentTargetIndex);
        // 위 정보를 바탕으로 이동해야할 방향을 계산
        Vector3 direction = (targetTrf.position - transform.position).normalized;
        // 방향을 계산했으면 거기로 이동
        transform.position += direction*_moveSpeed * Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

public class MoveSpawner : MonoBehaviour
{
    //소환할 프리팹
    [SerializeField] private GameObject _movePrefab;
    //소환 대상에게 전달할 웨이포인트
    [SerializeField] private Transform _waypointBox;
    //소환 간격(딜레이)
    [SerializeField] private float _spawnDelay;
    private WaitForSeconds _delay;
    void Start()
    {
        _delay = new WaitForSeconds(_spawnDelay);
        StartCoroutine(SpawnMover());
    }

   private IEnumerator SpawnMover()
    {
        if(_waypointBox == null)
        {
            yield break;
        }
        while (true)
        {

            //새로운 객체 생성
            GameObject newMoverObj = Instantiate(_movePrefab, transform);
            
            WayPointMover newMover = newMoverObj.GetComponent<WayPointMover>();
            newMover?.SetWayPointBox(_waypointBox);
            yield return _delay;
        }
    }
}

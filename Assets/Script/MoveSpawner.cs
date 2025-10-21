using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

public class MoveSpawner : MonoBehaviour
{
    //��ȯ�� ������
    [SerializeField] private GameObject _movePrefab;
    //��ȯ ��󿡰� ������ ��������Ʈ
    [SerializeField] private Transform _waypointBox;
    //��ȯ ����(������)
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

            //���ο� ��ü ����
            GameObject newMoverObj = Instantiate(_movePrefab, transform);
            
            WayPointMover newMover = newMoverObj.GetComponent<WayPointMover>();
            newMover?.SetWayPointBox(_waypointBox);
            yield return _delay;
        }
    }
}

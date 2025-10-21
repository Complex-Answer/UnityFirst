using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnController : MonoBehaviour
{
    //소환할 몹
    [SerializeField] GameObject _SpawnPrefab;
    //소환 쿨타임
    [SerializeField] float _SpawnDelay;

    private WaitForSeconds _delay;

    private void Start()
    {
        _delay = new WaitForSeconds(_SpawnDelay);
        StartCoroutine(Spawner());
    }


    private IEnumerator Spawner()
    {
        while (true)
        {
           yield return _delay;
           if (GameManger.Instance.IsPlaying)
            {
                System.Random rnd = new System.Random();
                //게임 오브젝트 객체 생성
                GameObject newObj = Instantiate(_SpawnPrefab, transform);
                newObj.transform.position = new Vector3(rnd.Next(-50, 50), 1, 36);
            }

        }
    }
}

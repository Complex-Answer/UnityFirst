using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnController : MonoBehaviour
{
    //��ȯ�� ��
    [SerializeField] GameObject _SpawnPrefab;
    //��ȯ ��Ÿ��
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
                //���� ������Ʈ ��ü ����
                GameObject newObj = Instantiate(_SpawnPrefab, transform);
                newObj.transform.position = new Vector3(rnd.Next(-50, 50), 1, 36);
            }

        }
    }
}

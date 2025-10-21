using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;
    //�ܺ� ������ ������Ƽ, �̱����� ������ ã�ƺ��� �׷��� ������ ���� ������
    public static T Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<T>();

                if(instance == null)
                {
                    GameObject singletonObj = new GameObject();
                    instance = singletonObj.AddComponent<T>();
                    singletonObj.name = typeof(T).ToString();
                }
            }
            return instance;
        }
    }
    protected virtual void Awake()
    {
        if(instance == null)
        {
            instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if(instance != this)
            {
                Destroy(gameObject);
            }
        }
    }
}

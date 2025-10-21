using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanA : MonoBehaviour, IObserver
{
    [SerializeField] private Subject subject;

    //�������ֱ�
    private void Awake()
    {
        subject.AddObserver(this);
    }
    //�������
    private void OnDestroy()
    {
        subject.RemoverObserver(this);
    }
    //�������̽� ��ӹ��� ��?��
    public void Onnotify()
    {
        Debug.Log($"{gameObject.name} ���Ź���");
    }
}

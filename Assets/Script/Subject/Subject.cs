using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
    //������ ����Ʈ
    private List<IObserver> observers = new List<IObserver>();
    //�����ϱ�
    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }
    //����(������Ҷ�� ��)
    public void RemoverObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    private void Start()
    {
        Notify();
    }

    private void Notify()
    {
        foreach (IObserver observer in observers)
        {
            observer.Onnotify();
        }
    }
}
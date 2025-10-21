using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
    //구독자 리스트
    private List<IObserver> observers = new List<IObserver>();
    //구독하기
    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }
    //구취(구독취소라는 뜻)
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
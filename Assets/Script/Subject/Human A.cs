using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanA : MonoBehaviour, IObserver
{
    [SerializeField] private Subject subject;

    //구독해주기
    private void Awake()
    {
        subject.AddObserver(this);
    }
    //구독취소
    private void OnDestroy()
    {
        subject.RemoverObserver(this);
    }
    //인터페이스 상속받은 증?거
    public void Onnotify()
    {
        Debug.Log($"{gameObject.name} 수신받음");
    }
}

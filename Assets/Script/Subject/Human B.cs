using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HumanB : MonoBehaviour, IObserver
{
    [SerializeField] private Subject subject;
    private void Awake()
    {
        subject.AddObserver(this);
    }
    private void OnDestroy()
    {
        subject.RemoverObserver(this);
    }
    public void Onnotify()
    {
        Debug.Log($"{gameObject.name} 수신받음");
    }
}

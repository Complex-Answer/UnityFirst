using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    private void OnTriggerEnter(Collider any)
    {
        if (any.gameObject.tag == "Player")
        {
            Debug.Log("<color=#fe6584>�÷��̾ ���� ���� ���Դ�</color>");
        }
    }
    private void OnTriggerStay(Collider any)
    {
        if (any.gameObject.tag == "Player")
        {
            Debug.Log("�÷��̾ ���� ���� �����Ѵ�");
        }
    }
    private void OnTriggerExit(Collider any)
    {
        if (any.gameObject.tag == "Player")
        {
            Debug.Log("�÷��̾ ������ �����");
        }
    }
}

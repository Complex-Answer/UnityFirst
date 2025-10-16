using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision any)
    {
        if (any.gameObject.tag == "Player")
        {
            Debug.Log("<color=#fe6584>�÷��̾�� ��Ҵ�</color>");
        }
    }
    private void OnCollisionStay(Collision any)
    {
        if(any.gameObject.tag == "Player")
        {
            Debug.Log("�÷��̾�� ����ִ�");
        }
    }
    private void OnCollisionExit(Collision any)
    {
        if(any.gameObject.tag == "Player")
        {
            Debug.Log("�÷��̾�� ��������");
        }
    }
}

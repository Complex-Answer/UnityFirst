using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    private void OnTriggerEnter(Collider any)
    {
        if (any.gameObject.tag == "Player")
        {
            Debug.Log("<color=#fe6584>플레이어가 영역 내로 들어왔다</color>");
        }
    }
    private void OnTriggerStay(Collider any)
    {
        if (any.gameObject.tag == "Player")
        {
            Debug.Log("플레이어가 영역 내에 존재한다");
        }
    }
    private void OnTriggerExit(Collider any)
    {
        if (any.gameObject.tag == "Player")
        {
            Debug.Log("플레이어가 영역을 벗어났다");
        }
    }
}

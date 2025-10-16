using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision any)
    {
        if (any.gameObject.tag == "Player")
        {
            Debug.Log("<color=#fe6584>ÇÃ·¹ÀÌ¾î¶û ´ê¾Ò´Ù</color>");
        }
    }
    private void OnCollisionStay(Collision any)
    {
        if(any.gameObject.tag == "Player")
        {
            Debug.Log("ÇÃ·¹ÀÌ¾î¶û ´ê¾ÆÀÖ´Ù");
        }
    }
    private void OnCollisionExit(Collision any)
    {
        if(any.gameObject.tag == "Player")
        {
            Debug.Log("ÇÃ·¹ÀÌ¾î¶û ¶³¾îÁ³´Ù");
        }
    }
}

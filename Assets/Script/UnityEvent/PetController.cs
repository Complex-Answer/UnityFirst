using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetController : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float moveStopDistance;

    private Coroutine moveCoroutine;
    private void Awake()
    {
        Init();
    }
    private void Init()
    {
        player.OnPetCalled.AddListener(MoveToPlayer);
    }
    public void MoveToPlayer()
    {
        moveCoroutine ??= StartCoroutine(MoveToTarget(player.transform));
    }
    private IEnumerator MoveToTarget(Transform target)
    {
        while (true)
        {
            float distance = Vector3.Distance(target.transform.position, transform.position);

            if(distance<= moveStopDistance)
            {
                moveCoroutine = null;
                yield break;
            }
            
              transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);

              yield return null;
            
        }
    }
}

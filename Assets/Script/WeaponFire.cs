using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class WeaponFire : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _spawn;
    [SerializeField] private float _attackSpeed; 

    private int _count = 0;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FireBullet();
            
        }
    }

    void FireBullet()
    {
        GameObject bullet = Instantiate(_bullet,_spawn.position,_spawn.rotation);
        bullet.name = $"Bullet + {_count}";
        _count++;
    }
}

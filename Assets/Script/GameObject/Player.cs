using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform _transStartForm;
    [SerializeField] private float _maxHp;
    [SerializeField] private float _fireDelay;
    
    private List<IPlayerHpObserver> hpObservers = new List<IPlayerHpObserver>();
    public void AddHpObserver(IPlayerHpObserver Observer)
    {
        hpObservers.Add(Observer);
    }
    public void RemoverHpObserver(IPlayerHpObserver Observer)
    {
        hpObservers.Remove(Observer);
    }

    private float _curHp;
    private void Awake()
    {
        GameManger.Instance.OnGameStartAction += InitPlayer;
    }
    void Start()
    {
        InitPlayer();
    }
    void InitPlayer()
    {
        _curHp = _maxHp;
        //transform.position = _transStartForm.position;
        gameObject.SetActive(true);

        NotifyHpUpdate();
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTakeDamage(float damage)
    {
        _curHp -= damage;

        NotifyHpUpdate();

        if (_curHp <= 0)
        {
            _curHp = 0;
            GameManger.Instance.ChangeGameState();
            gameObject.SetActive(false);
        }
        Debug.Log("현재 체력: "+_curHp);
    }

    private void NotifyHpUpdate()
    {
        foreach (var observer in hpObservers)
        {
            observer.HpObserverChange(_curHp, _maxHp);
        }
        
    }
}

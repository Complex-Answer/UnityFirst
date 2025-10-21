using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : Singleton<GameManger>
{
    [SerializeField] private bool _isPlaying = false;

    
    
    public bool IsPlaying { get { return _isPlaying; } }
    public event Action OnGameStartAction;

    //���������� �����ϴ� �Լ� false�� true��, true�� false��
    public void ChangeGameState()
    {
        _isPlaying = !_isPlaying;

        if (_isPlaying)
        {
            OnGameStartAction.Invoke();
        }
    }
}

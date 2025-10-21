using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : Singleton<GameManger>
{
    [SerializeField] private bool _isPlaying = false;

    
    
    public bool IsPlaying { get { return _isPlaying; } }
    public event Action OnGameStartAction;

    //게임진행을 변경하는 함수 false는 true로, true는 false로
    public void ChangeGameState()
    {
        _isPlaying = !_isPlaying;

        if (_isPlaying)
        {
            OnGameStartAction.Invoke();
        }
    }
}

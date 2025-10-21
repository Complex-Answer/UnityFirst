using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerHpObserver
{
    public void HpObserverChange(float curHp, float maxHp);
}

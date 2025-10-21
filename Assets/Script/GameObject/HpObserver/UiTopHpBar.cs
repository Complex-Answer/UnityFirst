using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiTopHpBar : MonoBehaviour,IPlayerHpObserver
{
   
    [SerializeField] private Image imageHpBar;
    [SerializeField] private Player player;
    

    private void Awake()
    {
        player.AddHpObserver(this);
    }
    private void OnDestroy()
    {
        player.RemoverHpObserver(this);
    }
    public void HpObserverChange(float curHp, float maxHp)
    {
        imageHpBar.fillAmount = curHp / maxHp;
    }
    
}

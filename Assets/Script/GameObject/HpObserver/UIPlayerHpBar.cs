using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayerHpBar : MonoBehaviour, IPlayerHpObserver
{
    [SerializeField] private float gap = 1.0f;
    [SerializeField] private Image imageHpBar;
    [SerializeField] private Player player;

    private Camera _camera;
    private Vector3 gapPos;

    private void Awake()
    {
        player.AddHpObserver(this);
    }
    private void OnDestroy()
    {
        player.RemoverHpObserver(this);
    }
    private void Start()
    {
        Init();
    }
    private void Update()
    {
        MoveTotarget();
    }
    private void Init()
    {
        if (_camera == null)
            _camera = Camera.main;

        gapPos = Vector3.forward * gap;
    }
    public void HpObserverChange(float curHp, float maxHp)
    {
        imageHpBar.fillAmount = curHp / maxHp;
    }
    private void MoveTotarget()
    {
        Vector3 movePos = player.transform.position + gapPos;
        transform.position = _camera.WorldToScreenPoint(movePos);
    }
}

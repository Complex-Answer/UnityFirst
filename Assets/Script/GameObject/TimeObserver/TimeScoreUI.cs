using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;

public class TimeScoreUI : MonoBehaviour,ITimeObserver
{
    [SerializeField] private ScoreText scoreText;
    [SerializeField] private TextMeshProUGUI timeText;



    private void Awake()
    {
        scoreText.AddTimeObservers(this);
    }
    private void OnDestroy()
    {
        scoreText.RemoveTimeObservers(this);
    }
   

    public void TimeScoreCheck(float playingtime)
    {
        timeText.text = "Score: " + playingtime.ToString();
        Debug.Log("��ӳ����� ���ּ�");
    }
    
   


}

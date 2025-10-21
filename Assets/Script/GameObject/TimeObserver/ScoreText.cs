using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    
    List<ITimeObserver> timeObservers = new List<ITimeObserver>();

    private WaitForSeconds ScoreRaise;
    private void Start()
    {
        
        TimeView();
        ScoreRaise = new WaitForSeconds(1);
        StartCoroutine(ScoreAdd());

    }
    private void FixedUpdate()
    {
    }
    int score = 0;
    private IEnumerator ScoreAdd()
    {
        while (true)
        {
            yield return ScoreRaise;
            if (GameManger.Instance.IsPlaying == false)
            {
                yield return null;
                break;
            }
            else
            {
                Debug.Log($"{score}√ ");
                TimeView();
                score++;
                
            }
        }
    }
    public void AddTimeObservers(ITimeObserver observer)
    {
        timeObservers.Add(observer);
    }
    public void RemoveTimeObservers(ITimeObserver observer)
    {
        timeObservers.Remove(observer);
    }

    public void TimeView()
    {
        foreach (var timeObserver in timeObservers)
        {
            timeObserver.TimeScoreCheck(score);
           
        }
    }
}

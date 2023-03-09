using System;
using UnityEngine;


public class CountDownTimeManager : MonoBehaviour
{
    public float timeLeft;
    public bool timerOn = false;
    public Action<int> timeSurvivedByPlayer;
    float timesurvived = 0.0f;
    public float maxTime;
    

    void Start()
    {
        timerOn = true;    
    }

    
    void Update()
    {
        if(timerOn) 
        {
            if(timeLeft > 0) 
            {
                timeLeft -= Time.deltaTime;
                UpdateTimer(timeLeft);
                timesurvived += Time.deltaTime;
                timeSurvivedByPlayer?.Invoke((int)timesurvived);
                TimeSurvivedByPlayer(timesurvived);
                Updateo2Bar(maxTime, timeLeft);
            }
        }
        else
        {
            Debug.Log("Time is Up");
            timeLeft = 0;
            timerOn= false;
        }
    }

    void UpdateTimer(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
        UIManager.instance.timerText.text = string.Format("{0:00}:{1:00}",minutes,seconds); 
    }

    public bool IsTimeUp()
    {
        return timeLeft <= 0;
    }

    float TimeSurvivedByPlayer(float time)
    {
        return time;
    }

    void Updateo2Bar(float maxo2, float currento2)
    {
        UIManager.instance.o2Bar.fillAmount = currento2/maxo2;
    }
}

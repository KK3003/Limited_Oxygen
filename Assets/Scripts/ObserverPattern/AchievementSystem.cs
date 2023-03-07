using UnityEngine;

public class AchievementSystem : MonoBehaviour
{
    CountDownTimeManager countDownTimeManager;
    void TimeSurvivedAchievement(float time)
    {
        switch (time)
        {
            case >= 5.0f:
                Debug.Log("Survived Achieved");
                UIManager.instance.timeSurvivedAchievementPanel.gameObject.SetActive(true);
                UIManager.instance.timeSurvivedAchievementText.text = "10 Seconds Survived";
                break;
        }     
    }
   


    void Start()
    {
        Debug.Log("In Achevement");
        countDownTimeManager = GameObject.FindObjectOfType<CountDownTimeManager>();
        countDownTimeManager.timeSurvivedByPlayer += TimeSurvivedAchievement;
    }

    private void OnDisable()
    {
        countDownTimeManager.timeSurvivedByPlayer -= TimeSurvivedAchievement;
    }
}

using UnityEngine;

public class AchievementSystem : MonoBehaviour
{
    public CountDownTimeManager countDownTimeManager;
    void TimeSurvivedAchievement(int time)
    {
        switch (time)
        {
            case 10:
                Debug.Log("Survived Achieved");
                UIManager.instance.timeSurvivedAchievementPanel.gameObject.SetActive(true);
                UIManager.instance.timeSurvivedAchievementText.text = "10 Seconds Survived";
                break;
            case 30:
                Debug.Log("Survived Achieved");
                UIManager.instance.timeSurvivedAchievementPanel.gameObject.SetActive(true);
                UIManager.instance.timeSurvivedAchievementText.text = "30 Seconds Survived";
                break;
            case 50:
                Debug.Log("Survived Achieved");
                UIManager.instance.timeSurvivedAchievementPanel.gameObject.SetActive(true);
                UIManager.instance.timeSurvivedAchievementText.text = "50 Seconds Survived";
                break;
            default:
                UIManager.instance.timeSurvivedAchievementPanel.gameObject.SetActive(false);
                UIManager.instance.timeSurvivedAchievementText.text = "";
                break;
        }     
    }
   


    void Start()
    {
        Debug.Log("In Achevement");
        countDownTimeManager.timeSurvivedByPlayer += TimeSurvivedAchievement;
    }

    private void OnDisable()
    {
        countDownTimeManager.timeSurvivedByPlayer -= TimeSurvivedAchievement;
    }
}

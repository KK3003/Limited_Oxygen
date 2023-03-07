using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public static UIManager instance;
    private void Awake()
    {
        if(instance== null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public Joystick joystick;
    public Text timerText;
    public GameObject timeSurvivedAchievementPanel;
    public Text timeSurvivedAchievementText;
    public Image o2Bar;
    public GameObject gameOverPanel;
    public GameObject gameWinPanel;
}

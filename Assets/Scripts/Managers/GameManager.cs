using UnityEngine;

public class GameManager : MonoBehaviour
{
   public static GameManager instance;
   public CountDownTimeManager countDownTimeManager;
  
    private void Awake()
    {
        if(instance == null) 
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        if(countDownTimeManager.IsTimeUp())
        {
            Time.timeScale = 0;
            UIManager.instance.gameOverPanel.SetActive(true);
            Debug.Log("game over");
        }
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Play()
    {
        Time.timeScale = 1;
    }

}

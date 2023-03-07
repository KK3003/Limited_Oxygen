using UnityEngine;

public class GameManager : MonoBehaviour
{
   public static GameManager instance;
   private CountDownTimeManager countDownTimeManager;
  
   

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
        countDownTimeManager = GameObject.FindObjectOfType<CountDownTimeManager>();
    }

    private void Update()
    {
        if(countDownTimeManager.IsTimeUp())
        {
            //gameover observer pattern
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

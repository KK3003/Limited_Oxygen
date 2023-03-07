using UnityEngine;

public class PlayerView : MonoBehaviour
{
    public PlayerController playerController;
    EnemyController enemyController;
    private float movement;
    private float rotation;


   
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 2f, 1f);
        // playerController = GetComponent<PlayerController>();
    }



    private void Update()
    {

        Movement();
       
        if (movement != 0)
        {
            playerController.Move(movement, playerController.GetPlayerModel().MovementSpeed);
        }

        if (rotation != 0)
        {
            playerController.Roatate(rotation, playerController.GetPlayerModel().RotationSpeed);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerController.Jump();
        }

    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

  

    public void SetPlayerController(PlayerController _playerController)
    {
        playerController = _playerController;
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<EnemyView>())
        {
            Time.timeScale = 0;
            UIManager.instance.gameOverPanel.SetActive(true);
            Debug.Log("Collided with Player");
        }
        if (collision.gameObject.GetComponent<GameWinPoint>())
        {
            Time.timeScale = 0;
            UIManager.instance.gameWinPanel.SetActive(true);
            Debug.Log("WOn");
        }
    }
}

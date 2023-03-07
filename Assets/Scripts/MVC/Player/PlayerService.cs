using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerService : MonoBehaviour
{
    public PlayerController playerController;
    public PlayerView playerView;
    PlayerModel playerModel;
    public PlayerScriptableObject[] playerConfigurations;


    public static PlayerService instance;

    private void Awake()
    {
        if (instance == null)
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
        SpawnPlayer();  
    }

    public void SpawnPlayer()
    {
        //int tankToSpawn = Random.Range(1, 3);
        //Debug.Log("Tank number" + tankToSpawn);
        CreateNewTank();

    }

    public Transform PlayerPosition() { return playerController.Playerpos(); }

    private PlayerController CreateNewTank()
    {
        PlayerScriptableObject playerScriptableObject = playerConfigurations[0];
        PlayerModel model = new PlayerModel(playerScriptableObject);
        playerController = new PlayerController(model, playerView);
        return playerController;
    }
}

using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject playercamera;
    PlayerView playerView;

    void Start()
    {
        playerView = GetComponent<PlayerView>();
        playercamera.transform.SetParent(playerView.transform);
        playercamera.transform.position = new Vector3(0f, 2f, 1f);
    }    
}

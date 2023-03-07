using UnityEngine;

public class PlayerController
{
    public PlayerModel playerModel;
    private PlayerView playerView;
    private Rigidbody rb;
    public Joystick joystick;

    public PlayerController(PlayerModel _playerModel, PlayerView _playerView)
    {
        playerModel = _playerModel;
        playerView = _playerView;
        playerView = GameObject.Instantiate<PlayerView>(_playerView);
        rb = playerView.GetComponent<Rigidbody>(); 
        playerView.SetPlayerController(this);
    }


    public void Move(float movement, float movementeSpeed)
    {
        rb.velocity = playerView.transform.forward * movement * movementeSpeed;
    }

    public void Roatate(float rotate, float rotatespeed)
    {
        Vector3 vector = new Vector3(0f, rotate * rotatespeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }



    public void Jump()
    {
        rb.AddForce(Vector3.up * playerModel.JumpForce, ForceMode.Impulse);
    }

    public Transform Playerpos() { return playerView.transform; }

    public PlayerModel GetPlayerModel()
    {
        return playerModel;
    }
}

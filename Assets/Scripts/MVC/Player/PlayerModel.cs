public class PlayerModel
{

    public PlayerModel(PlayerScriptableObject playerScriptableObject)
    {
        Health = playerScriptableObject.health;
        MovementSpeed= playerScriptableObject.movementSpeed;
        RotationSpeed = playerScriptableObject.rotationSpeed;
        JumpForce = playerScriptableObject.jumpForce;    
    }

   public float Health { get; set; }
   public float MovementSpeed { get; }
    public float RotationSpeed { get; }
    public float JumpForce { get; }
}

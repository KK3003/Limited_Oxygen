using UnityEngine;

[CreateAssetMenu(fileName ="PlayerScriptableObject", menuName ="ScriptableObject/Player")]
public class PlayerScriptableObject : ScriptableObject
{
    public string playerName;
    public float movementSpeed;
    public float rotationSpeed;
    public float health;
    public float jumpForce;
}

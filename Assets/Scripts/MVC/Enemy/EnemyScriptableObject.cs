using UnityEngine;

[CreateAssetMenu(fileName = "EnemyScriptableObject", menuName ="ScriptableObject/Enemy")]
public class EnemyScriptableObject : ScriptableObject
{
    public string enemyName;
    public float health;
    public float chaseRange;
    public Transform target;
    public Transform[] wayPoints;

}


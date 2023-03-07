using UnityEngine;

public class EnemyModel
{
    public EnemyModel(EnemyScriptableObject enemyScriptableObject)
    {
        Health = enemyScriptableObject.health;
        ChaseRange= enemyScriptableObject.chaseRange;
        Target = enemyScriptableObject.target;
        WayPoints= enemyScriptableObject.wayPoints;
    }


    public float Health { get; set; }
    public float ChaseRange { get; }
    public Transform Target;
    public Transform[] WayPoints { get; }
}

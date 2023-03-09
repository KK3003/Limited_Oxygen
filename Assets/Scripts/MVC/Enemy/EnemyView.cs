using UnityEngine;
using UnityEngine.AI;

public class EnemyView : MonoBehaviour
{
    public EnemyController enemyController;
    public NavMeshAgent navMeshAgent;


    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }


    public void SetEnemyController(EnemyController _enemyController)
    {
        enemyController = _enemyController;
    }  
}

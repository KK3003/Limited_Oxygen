using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public EnemyModel enemyModel;
    private EnemyView enemyView;
    int _currentWaypoint;
    public int destPoints = 0;
    protected EnemyState currentState;
    


    public EnemyController(EnemyModel _enemyModel, EnemyView _enemyView, Transform _enemySpawnPos)
    {
        enemyModel = _enemyModel;
        enemyView = _enemyView;
        enemyView = GameObject.Instantiate<EnemyView>(_enemyView, _enemySpawnPos);
        enemyView.SetEnemyController(this);
        ChangeState(enemyView.GetComponent<EnemyChasingState>());
    }


    public void Patrolling()
    {
        if (enemyView.navMeshAgent.remainingDistance < 1f)
        {
            if (destPoints >= enemyModel.WayPoints.Length - 1)
            {
                destPoints = 0;
            }
            else
            {
                destPoints++;
            }
            enemyView.navMeshAgent.SetDestination(enemyModel.WayPoints[destPoints].transform.position);
        }
    }

    public bool IsPatrolling()
    {
        Transform wp = enemyModel.WayPoints[_currentWaypoint];
        return Vector3.Distance(enemyView.transform.position, wp.position) < 0.01f;
    }

    public void ChasingPlayer()
    {
      
        enemyView.transform.LookAt(PlayerService.instance.PlayerPosition().position);
        enemyView.navMeshAgent.SetDestination(PlayerService.instance.PlayerPosition().position);
    }

    public bool IsInChaseRange()
    {

        return DistanceBetPlayer() <= enemyModel.ChaseRange;
    }

    public void ChangeState(EnemyState newState)
    {
        if (currentState != null)
        {
            currentState.OnExitState();
        }
        currentState = newState;
        currentState.OnEnterState();
    }


    public NavMeshAgent EnemyNavMeshAgent()
    {
        return enemyView.navMeshAgent;
    }

    private float DistanceBetPlayer()
    {
        if (enemyView == null)
        {
            return Mathf.Infinity;
        }
        return Vector3.Distance(PlayerService.instance.PlayerPosition().position, enemyView.transform.position);
    }
}

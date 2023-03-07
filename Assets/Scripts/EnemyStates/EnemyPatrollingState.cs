using UnityEngine;

public class EnemyPatrollingState : EnemyState
{
    int currentIndex;

    public override void OnEnterState()
    {
        base.OnEnterState();
        currentIndex = -1;
        Debug.Log("Entering state: Patrolling");

    }


    private void Update()
    {
        enemyView.enemyController.Patrolling();
        Debug.Log("Is in Patrolling State");
        if (enemyView.enemyController.IsInChaseRange())
        {
            enemyView.enemyController.ChangeState(GetComponent<EnemyChasingState>());
            return;
        }

    }
}

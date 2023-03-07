using UnityEngine;

public class EnemyService : MonoBehaviour
{
    public EnemyView enemyView;
    public EnemyScriptableObject[] enemyConfiguration;


    void Start()
    {
        SpawnEnemy();
    }

    public void SpawnEnemy()
    {
       
        CreateNewEnemy();
    }

    private EnemyController CreateNewEnemy()
    {
        EnemyScriptableObject enemyScriptableObject = enemyConfiguration[0];
        EnemyModel model = new EnemyModel(enemyScriptableObject);
        EnemyController enemy = new EnemyController(model, enemyView, this.gameObject.transform);
        return enemy;
    }
}

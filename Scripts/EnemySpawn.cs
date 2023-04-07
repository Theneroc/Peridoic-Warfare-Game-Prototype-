using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject prefab;
    public GameController gameController;
    public int MaxNumOfEnemies;
    int currNumOfEnemies = 0;
    float xDir;
    float zDir;
    int currScore;
    Vector3 spawnP;
    // Start is called before the first frame update
    void Start()
    {
        currScore = gameController.GetScore();
    }

    // Update is called once per frame
    void Update()
    {
        if (currNumOfEnemies < MaxNumOfEnemies)
        {
            ++currNumOfEnemies;
            xDir = Random.Range(-50, 50);
            zDir = Random.Range(-50, 50);
            setSpawnPosition(xDir, zDir);
            GameObject currEnemy = Instantiate(prefab,new Vector3(xDir, .5f, zDir), Quaternion.identity);
            currEnemy.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
        if (gameController.GetScore() > currScore)
        {
            --currNumOfEnemies;
            currScore = gameController.GetScore();
        }
        
    }
    void setSpawnPosition(float xDir,float zDir)
    {
        spawnP = new Vector3(xDir, 0f, zDir);
    }
    public Vector3 getSpawnPoint()
    {
        return spawnP;
    }
}

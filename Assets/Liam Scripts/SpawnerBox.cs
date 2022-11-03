using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBox : MonoBehaviour
{
    public GameObject slime;   
    //public int amount = 1;
    public GameObject[] spawnersSlime;
    // Start is called before the first frame update
    void Start()
    {
        if (spawnersSlime == null)
        {
            spawnersSlime = GameObject.FindGameObjectsWithTag("SlimeEnemySpawner");
        }
        foreach (GameObject SlimeEnemySpawner in spawnersSlime)
        {
            Instantiate(slime, SlimeEnemySpawner.transform.position, Quaternion.identity);
        }
        
        
    }

    //private void SpawnWave(int numberOfEnemies)
    //{
    //    //Spawn meteors
    //    for (int i = 0; i < numberOfEnemies; i++)
    //    {
    //        SpawnEnemy();
    //    }
    //}

    //private void SpawnEnemy()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public int amount = 5;


    float width, height;

    void Start()
    {
        //Get screen size
        width = Camera.main.orthographicSize * Camera.main.aspect;
        height = Camera.main.orthographicSize;

        //Spawn the first wave
        SpawnWave(amount);
    }

    private void SpawnWave(int numberOfEnemies)
    {
        //Spawn meteors
        for (int i = 0; i < numberOfEnemies; i++)
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        Vector2 randomPosition = new Vector2();
        randomPosition.x = Random.Range(-width, width);
        randomPosition.y = Random.Range(-height, height);

        Quaternion randomRotation = Quaternion.Euler(0, 0, Random.Range(0, 0f));

        Instantiate(enemy, randomPosition, randomRotation, transform);
    }
}

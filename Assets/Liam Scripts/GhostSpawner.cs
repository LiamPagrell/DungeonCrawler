using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{
    public GameObject ghost;

    public GameObject[] spawnersGhost;
    // Start is called before the first frame update
    void Start()
    {
        if (spawnersGhost == null)
        {
            spawnersGhost = GameObject.FindGameObjectsWithTag("GhostEnemySpawner");
        }
        foreach (GameObject GhostEnemySpawner in spawnersGhost)
        {
            Instantiate(ghost, GhostEnemySpawner.transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

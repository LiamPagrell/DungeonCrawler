using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject Player;
    //public int amount = 1;
    public GameObject[] playerSpawner1;
    // Start is called before the first frame update
    void Start()
    {
        if (playerSpawner1 == null)
        {
            playerSpawner1 = GameObject.FindGameObjectsWithTag("PlayerSpawner");
        }
        foreach (GameObject PlayerSpawner in playerSpawner1)
        {
            Instantiate(Player, PlayerSpawner.transform.position, Quaternion.identity);
        }
    }
}
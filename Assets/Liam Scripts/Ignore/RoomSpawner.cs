using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int openingDirection;
    // interger for spawning the different doors/layouts
    // 1 = Need bottom door
    // 2 = Need top door
    // 3 = Need left door
    // 4 = Need right door

    private RoomTemplates templates;
    private int randomNumber;
    public bool spawned = false;

    // Start is called before the first frame update
    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>(); // Varför fungerar inte FindGameObjectsWithTag, GameObjects med s
        Invoke("Spawn", 3f);
    }

    // Update is called once per frame
    void Spawn()
    {
        if(spawned == false)
        {
            //randomNumber = Random.Range(0, templates.FourWayRoom.Length);
            //Instantiate(templates.FourWayRoom[randomNumber], transform.position, templates.RoomsWithBottomDoors[randomNumber].transform.rotation);

            //if (openingDirection == 1)
            //{
            //    randomNumber = Random.Range(0, templates.RoomsWithBottomDoors.Length);
            //    Instantiate(templates.RoomsWithBottomDoors[randomNumber], transform.position, templates.RoomsWithBottomDoors[randomNumber].transform.rotation);
            //}
            //else if (openingDirection == 2)
            //{
            //    randomNumber = Random.Range(0, templates.RoomsWithTopDoors.Length);
            //    Instantiate(templates.RoomsWithTopDoors[randomNumber], transform.position, templates.RoomsWithTopDoors[randomNumber].transform.rotation);
            //}
            //else if (openingDirection == 3)
            //{
            //    randomNumber = Random.Range(0, templates.RoomsWithLeftDoors.Length);
            //    Instantiate(templates.RoomsWithLeftDoors[randomNumber], transform.position, templates.RoomsWithLeftDoors[randomNumber].transform.rotation);
            //}
            //else if (openingDirection == 4)
            //{
            //    randomNumber = Random.Range(0, templates.RoomsWithRightDoors.Length);
            //    Instantiate(templates.RoomsWithRightDoors[randomNumber], transform.position, templates.RoomsWithRightDoors[randomNumber].transform.rotation);
            //}
            spawned = true;
        }

       
    }
    void OnTriggerEnter2D(Collider2D RoomSpawnPoint)
    {
        if (RoomSpawnPoint.CompareTag("RoomSpawnPointMid")) // Skapa en ny tag för Spawnpoint mid, skapa ny kod för att bara talla med den
        {
            Destroy(gameObject);
        }
    }
}

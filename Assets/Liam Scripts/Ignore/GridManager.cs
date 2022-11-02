using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int rows = 10;
    public int columns = 10;
    public float GridSpacingOffset = 1;
    private int randomNumber;
    private RoomTemplates templates;
    public Vector2 gridOrigin = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>(); // Varför fungerar inte FindGameObjectsWithTag, GameObjects med s
        Invoke("Spawn", 1f);        
    }

    private void Spawn()
    {
       
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                Vector2 spawnPosition = new Vector2(r * GridSpacingOffset, c * GridSpacingOffset) + gridOrigin;
                Spawner(spawnPosition, Quaternion.identity);
                   
                    //GameObject tile = (GameObject)Instantiate(templates, transform);

                    //float posX = c * tileSize;
                    //float posY = r * -tileSize;

                    //tile.transform.position = new Vector2(posX, posY);
            }
        }
        //Destroy(templates);
    }

    void Spawner(Vector2 positionToSpawn, Quaternion rotationToSpawn)
    {
        randomNumber = Random.Range(0, templates.GridRooms.Length);
        Instantiate(templates.GridRooms[randomNumber], positionToSpawn, rotationToSpawn);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

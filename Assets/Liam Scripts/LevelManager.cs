using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject prefabStart;
    //public GameObject prefabOne;
    //public GameObject prefabTwo;
    //public GameObject prefabThree;
    //public GameObject prefabFour;
    //private CallToPlayer ploob;
    private RoomTemplates templates;
    private int RandomNumber;

    private GameObject prefab;
    private GameObject currentObject;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
        Debug.Log(player);
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        prefab = prefabStart;
        currentObject = Instantiate(prefab, transform.position, Quaternion.identity);      
    }

    // Update is called once per framse
    void Update()
    {
        if(Input.GetKeyDown("1"))
        {
            LoadNewLevel();
            //RandomNumber = Random.Range(0, templates.prefablist.Length);
            //Destroy(currentObject);
            //Destroy(GameObject.FindGameObjectWithTag("Player"));
            //currentObject = Instantiate(templates.prefablist[RandomNumber], transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown("r"))
        {
            prefab = prefabStart;
            Destroy(currentObject);
            currentObject = Instantiate(prefab, transform.position, Quaternion.identity);
        }
        //if(Input.GetKeyDown("2"))
        //{
        //    prefab = prefabTwo;
        //}
        //if (Input.GetKeyDown("3"))
        //{
        //    prefab = prefabThree;
        //}
        //if (Input.GetKeyDown("4"))
        //{
        //    prefab = prefabFour;
        //}

        //if (Input.GetKeyDown("1"))
        //{
        //    Destroy(currentObject);
        //    currentObject = Instantiate(prefab, transform.position, Quaternion.identity);
        //}
        //if (Input.GetKeyDown("2"))
        //{
        //    Destroy(currentObject);
        //    currentObject = Instantiate(prefab, transform.position, Quaternion.identity);
        //}
        //if (Input.GetKeyDown("3"))
        //{
        //    Destroy(currentObject);
        //    currentObject = Instantiate(prefab, transform.position, Quaternion.identity);
        //}
        //if (Input.GetKeyDown("4"))
        //{
        //    Destroy(currentObject);
        //    currentObject = Instantiate(prefab, transform.position, Quaternion.identity);
        //}
    }
    public void LoadNewLevel()
    {      
        RandomNumber = Random.Range(0, templates.prefablist.Length);
        Destroy(currentObject);
        Destroy(GameObject.FindGameObjectWithTag("Player"));
        currentObject = Instantiate(templates.prefablist[RandomNumber], transform.position, Quaternion.identity);      
    }

}

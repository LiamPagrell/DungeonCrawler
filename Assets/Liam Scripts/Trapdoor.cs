using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trapdoor : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        LevelManager LvlMangr;
        if (other.gameObject.tag == "Player")
        {
            LvlMangr = GameObject.FindObjectOfType<LevelManager>(); //Call on LevelManager and make it a variable for easier use
            LvlMangr.LoadNewLevel(); //Call on the Function LoadNewLevel in LevelManager Trough the class
            LvlMangr.DestroyAllEnemies();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

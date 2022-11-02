using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
	public GameObject Player;
    public float PlayerMaxhealth  = 5f;
    int EnemieMaxhealth = 3;
    int Playercurrenthealth;
    int Enemiecurrenthealth;

    private float delayBeforeLoding = 4f;
    private float delayBeforeLoding2 = 8f;

    string sceneNameToLoad;

    float timer;
    void Start()
    {
        float Playercurrenthealth = PlayerMaxhealth;
        int Enemiecurrenthealth = EnemieMaxhealth;
    }
    void Update()
    {

    timer += Time.deltaTime;
    
    }
    

    public void OnTriggerEnter2D(Collider2D other)
	{
			
            if (other.gameObject.CompareTag("Bullet"))
            {
                //if this script is on player
                  if (Player.tag == "Player" )
                {
                    if (PlayerMaxhealth == 5)
                {
                    PlayerMaxhealth -=1;
                }
                else if (PlayerMaxhealth == 4)
                {
                    PlayerMaxhealth -=1;
                }
                else if (PlayerMaxhealth == 3)
                {
                    PlayerMaxhealth -=1;
                }
                else if (PlayerMaxhealth == 2)
                {
                    PlayerMaxhealth -=1;
                }
                else if (PlayerMaxhealth == 1)
                {
                    PlayerMaxhealth -=1;
                    
                    timer = 0;
                    for (int i = 0; i < 9; i++) 
                    {
                        timer += 1;
                        Debug.Log(timer);
                    if (timer > delayBeforeLoding)
                    {
                        SceneManager.LoadScene("GAMEOVER");
                    }
                    
                    for (int j = 0; j < 500; j++)
                    {
                        timer += 1;
                        if (timer > delayBeforeLoding + 500)
                    {
                        SceneManager.LoadScene("Menu");
                        timer = 0;
                    }
                    }
                
                    }
                }
                
                }
                //if  script is on Enemy
                if (Player.tag == "Enemy" )
                {
                    if (EnemieMaxhealth == 3)
                {
                    EnemieMaxhealth -=1;
                }
                else if (EnemieMaxhealth == 2)
                {
                    EnemieMaxhealth -=1;
                }
                else if (EnemieMaxhealth == 1)
                {
                    EnemieMaxhealth -=1;
                    Destroy(Player);
                }
                }
                timer = 0;
            }
	}  
}


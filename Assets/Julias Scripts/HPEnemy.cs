using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPEnemy : MonoBehaviour
{
    public float PlayerMaxhealth  = 5f;
    public GameObject Enemy;
    public HighScoreController HC;
    float timer;
    int points = 0;
    void Start()
    {
        HC = GameObject.Find("Canvas").GetComponent<HighScoreController>();
    }
    void Update()
    {
       timer += Time.deltaTime; 
    }
    public void OnTriggerEnter2D(Collider2D other)
	{

    if (other.gameObject.CompareTag("Weapon"))
        {
        if (Enemy.tag == "Enemy" )
            {
            if (PlayerMaxhealth == 5)
                {
                    PlayerMaxhealth -=1;
                    Debug.Log(PlayerMaxhealth);
                }
                
            else if (PlayerMaxhealth == 4)
                {
                    PlayerMaxhealth -=1;
                    Debug.Log(PlayerMaxhealth);
                }

            else if (PlayerMaxhealth == 3)
                {
                    PlayerMaxhealth -=1;
                    Debug.Log(PlayerMaxhealth);
                }

            else if (PlayerMaxhealth == 2)
                {
                    PlayerMaxhealth -=1;
                    Debug.Log(PlayerMaxhealth);
                }

            else if (PlayerMaxhealth == 1)
                {
                    PlayerMaxhealth -=1;
                    timer = 0;
                    Debug.Log(PlayerMaxhealth);
                    HC.score ++;
                    Destroy(Enemy);
                    Debug.Log(points+100);
                }
            }
        }
    }
			
}

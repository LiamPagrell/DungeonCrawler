using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public float PlayerMaxhealth  = 5f;
    public GameObject Player;
    float timer;
    void Update()
    {
       timer += Time.deltaTime; 
    }
    public void OnTriggerEnter2D(Collider2D other)
	{

    if (other.gameObject.CompareTag("Enemy"))
        {
        if (Player.tag == "Player" )
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
                }
            }
        }
    }
			
}
                    

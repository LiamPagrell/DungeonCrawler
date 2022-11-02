using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public float PlayerMaxhealth  = 5f;
    public GameObject Player;
    public GameObject Weapon;
    Animator anim;
    float timer;
    int EnemieMaxhealth = 3;
    int Playercurrenthealth;
    int Enemiecurrenthealth;

    void Start()
    {
        float Playercurrenthealth = PlayerMaxhealth;
        anim = GetComponent<Animator>();
    }
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
                    Debug.Log(PlayerMaxhealth+10);
                }
                
            else if (PlayerMaxhealth == 4)
                {
                    PlayerMaxhealth -=1;
                    Debug.Log(PlayerMaxhealth+10);
                }

            else if (PlayerMaxhealth == 3)
                {
                    PlayerMaxhealth -=1;
                    Debug.Log(PlayerMaxhealth+10);
                }

            else if (PlayerMaxhealth == 2)
                {
                    PlayerMaxhealth -=1;
                    Debug.Log(PlayerMaxhealth+10);
                }

            else if (PlayerMaxhealth == 1)
                {
                    PlayerMaxhealth -=1;
                    timer = 0;
                    Debug.Log(PlayerMaxhealth+10);
                    Destroy(Weapon);
                    anim.SetTrigger("Death");

                    SceneManager.LoadScene("GameOver");

                }
            }
        }
    }
			
}
                    

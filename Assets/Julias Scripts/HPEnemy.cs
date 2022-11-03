using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPEnemy : MonoBehaviour
{
    public float PlayerMaxhealth  = 5f;
    public GameObject Enemy;
    public HighScoreController HC;
    [SerializeField] AudioSource DeathsoundEnemy;
    [SerializeField] AudioSource Enemyhurt;
    Animator anim1;
    float timer;
    bool Death= false;
    int points = 0;
    void Start()
    {
        HC = GameObject.Find("Canvas").GetComponent<HighScoreController>();
        anim1 = GetComponent<Animator>();
    }
    void Update()
    {
       timer += Time.deltaTime; 
       if (timer > 0.5f && Death == true )
                {
                Debug.Log("Slime Is dead");
                Destroy(Enemy);
                }
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
                    Enemyhurt.Play();
                }
                
            else if (PlayerMaxhealth == 4)
                {
                    PlayerMaxhealth -=1;
                    Enemyhurt.Play();
                }

            else if (PlayerMaxhealth == 3)
                {
                    PlayerMaxhealth -=1;
                    Enemyhurt.Play();
                }

            else if (PlayerMaxhealth == 2)
                {
                    PlayerMaxhealth -=1;
                    Enemyhurt.Play();
                }

            else if (PlayerMaxhealth == 1)
                {
                    if (Death == false)
                    {
                        Death = true;
                        timer = 0;
                        anim1.SetTrigger("DeathOfSlime");
                        anim1.SetTrigger("Deathghost");
                    }
                    PlayerMaxhealth -=1;
                    timer = 0;
                    Debug.Log(PlayerMaxhealth);
                    HC.score ++;
                    anim1.SetTrigger("DeathOfSlime");
                    anim1.SetTrigger("Deathghost");
                    DeathsoundEnemy.Play();
                    Debug.Log(points+100);
                }
            }
        }
    }
			
}

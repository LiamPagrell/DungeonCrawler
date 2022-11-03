using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public float PlayerMaxhealth  = 5f;
    public GameObject Player;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public GameObject Heart4;
    public GameObject Heart5;
    public GameObject Weapon;
    Animator anim;

    [SerializeField] AudioSource Deathsound;
    [SerializeField] AudioSource Hurtsound;
    float timer;
    bool Death= false;
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
       if (timer > 1.9f && Death == true )
                {
                SceneManager.LoadScene("GameOver");
                }
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
                    Destroy(Heart1);
                    Hurtsound.Play();
                }
                
            else if (PlayerMaxhealth == 4)
                {
                    PlayerMaxhealth -=1;
                    Destroy(Heart2);
                    Hurtsound.Play();
                }

            else if (PlayerMaxhealth == 3)
                {
                    PlayerMaxhealth -=1;
                    Destroy(Heart3);
                    Hurtsound.Play();
                }

            else if (PlayerMaxhealth == 2)
                {
                    PlayerMaxhealth -=1;
                    Destroy(Heart4);
                    Hurtsound.Play();
                }

            else if (PlayerMaxhealth == 1)
                {
                    if (Death == false)
                    {
                        timer = 0;
                        Death = true;
                    }
                    
                    Destroy(Heart5);
                    Debug.Log(PlayerMaxhealth+10);
                    Destroy(Weapon);
                    anim.SetTrigger("Death");
                    Deathsound.Play();
                    Debug.Log(timer);
                }
            }
        }
    }
			
}
                    

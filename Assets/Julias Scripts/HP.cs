using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public float PlayerMaxhealth = 5f;
    public GameObject Player;
    private List<Transform> hearts;
    public GameObject Weapon;
    Animator anim;

    [SerializeField] AudioSource Deathsound;
    [SerializeField] AudioSource Hurtsound;
    float timer;
    bool Death = false;
    int EnemieMaxhealth = 3;
    int Playercurrenthealth;
    int Enemiecurrenthealth;

    void Start()
    {
        float Playercurrenthealth = PlayerMaxhealth;
        anim = GetComponent<Animator>();
        hearts = FindObjectOfType<HealthHolder>().hearts;
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1.9f && Death == true)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Enemy"))
        {
            if (Player.tag == "Player")
            {
                PlayerMaxhealth -= 1;
                for (int i = 0; i < hearts.Count; i++)
                {
                    hearts[i].gameObject.SetActive(i < PlayerMaxhealth);
                }
               

                if (PlayerMaxhealth <= 0)
                {
                    if (Death == false)
                    {
                        timer = 0;
                        Death = true;
                    }

             
                    Debug.Log(PlayerMaxhealth + 10);
                    Destroy(Weapon);
                    anim.SetTrigger("Death");
                    Deathsound.Play();
                    Debug.Log(timer);
                }
            }
        }
    }

}


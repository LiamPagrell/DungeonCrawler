using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    //Player Movement Speed, Rigidbody and spriteRend
	    public float speed = 2;
	    Rigidbody2D rb2d;
        SpriteRenderer spriteRend;

		HP player;
  
    //Current movement
	Vector2 movement = new Vector2();

	void Start()
	{
        //Find our Rigidbody2D
	    rb2d = GetComponent<Rigidbody2D>();
        spriteRend = GetComponent<SpriteRenderer>();
	}
	void Update()
	{
        //get input from player
        float y = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
		if (x < 0)
		{
			spriteRend.flipX = true;
		}
		else if (x>0)
		{
			spriteRend.flipX = false;
		}
			//update direction
			movement.x = x * speed;
        	movement.y = y * speed;

        	//Update our movement
			rb2d.velocity = movement;
		
	}
}
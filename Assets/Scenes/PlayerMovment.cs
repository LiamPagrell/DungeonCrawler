using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    //Player Movement Speed and Rigidbody
	    public float speed = 10;
	    Rigidbody2D rb2d;
  
    //Current movement
	Vector2 movement = new Vector2();

	void Start()
	{
        //Find our Rigidbody2D
	    rb2d = GetComponent<Rigidbody2D>();
	}
	void Update()
	{
        //get input from player
		float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        //update direction
		movement.x = x * speed;
        movement.y = y * speed;

        //Update our movement
		rb2d.velocity = movement;
	}
}
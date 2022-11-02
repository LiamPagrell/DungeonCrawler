using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public float speed = 4;
    Vector2[] dirs = { Vector2.up, Vector2.down, Vector2.right, Vector2.left };
    Vector2 dir;
    Rigidbody2D rb2d;
    Transform target;

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        rb2d = GetComponent<Rigidbody2D>();

        MoveNewDirection();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            MoveNewDirection();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        MoveNewDirection();
    }

    private void MoveNewDirection()
    {
        var oldDir = dir;

        //Get a new random direction
        if (Random.value > 0.5f)
        {
            do
            {
                dir = dirs[Random.Range(0, dirs.Length)];
            }
            while (dir == oldDir);
        }
        else
        {
            float distX = transform.position.x - target.position.x;
            float distY = transform.position.y - target.position.y;

            if (Mathf.Abs(distX) > Mathf.Abs(distY))
            {
                if (transform.position.x > target.position.x)
                    dir = Vector2.left;

                if (transform.position.x < target.position.x)
                    dir = Vector2.right;
            }
            else
            {
                if (transform.position.y > target.position.y)
                    dir = Vector2.up;

                if (transform.position.y < target.position.y)
                    dir = Vector2.down;
            }

        }

        //Start moving in the new direction
        rb2d.velocity = dir * speed;
        transform.up = dir; 

        //Time until new direction change.
        timer = Random.Range(0.5f, 2);
    }
}

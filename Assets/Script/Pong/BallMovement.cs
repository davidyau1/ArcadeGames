using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public Vector3 direction;
    public GameScript script;
    void BeginRound()
    {
       

    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        script =  gameObject.AddComponent<GameScript>();
    }
    private void Update()
    {

    }
    private void FixedUpdate()
    {
        Movement();
    }    
   
    void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Wall")
        {
            direction.y *= -1;
        }
        if (collision.gameObject.tag == "LeftGoal")
        {
            script.ScorePoint("left");
            if (GameScript.leftScore < 10)
            {
                gameObject.transform.position = new Vector3(0, 0, 0);
            }
            else
            {
                Destroy(gameObject);
            }

        }
        if (collision.gameObject.tag == "RightGoal")
        {
            script.ScorePoint("right");
            if (GameScript.rightScore < 10)
            {
                gameObject.transform.position = new Vector3(0, 0, 0);
            }
            else
            {
                Destroy(gameObject);
            }


        }
        if (collision.gameObject.tag == "Player")
        {
            direction.x *= -1;
        }

    }


    void Movement()
    {
        direction= direction.normalized;
        rb.velocity = direction *  speed*Time.fixedDeltaTime ;

    }
}

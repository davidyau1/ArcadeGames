using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public Vector3 direction;
    void BeginRound()
    {
        ////Spawns the ball at (0,0)
        //GameObject gameBall = Instantiate(ball, new Vector2(0, 0), Quaternion.identity);
        //gameBall.GetComponent<BallMovement>();
        //int side = Random.Range(0, 2);
        //if (side == 0)
        //{
        //    ballDirection.x = -1;
        //}
        //else
        //{
        //    ballDirection.x = 1;
        //}
        //gameBall.transform.position = ballDirection;

    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
        Debug.Log("We Hit Object");
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Wall")
        {
            direction.y *= -1;
        }
        if (collision.gameObject.tag == "LeftGoal")
        {
            direction.x *= -1;

        }
        if (collision.gameObject.tag == "RightGoal")
        {
            direction.x *= -1;

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

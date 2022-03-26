using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPlayer : PlayerControl
{
    public bool aiOn;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if (!aiOn)
        {

            if (Input.GetKey(KeyCode.UpArrow))
            {
                direction.y = 1;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                direction.y = -1;
            }
            else
            {
                direction.y = 0;
            }

        }
     
       
    
    }
    private void FixedUpdate()
    {
        MovePlayer();
    }
    void MovePlayer()
    {

        if (aiOn)
        {
            //Vector2 directionToGoal = (ball.position - transform.position);
            //directionToGoal.Normalize();
            //transform.position += (Vector3)directionToGoal * speed * Time.deltaTime;
        }
        else
        {
            rb.velocity = direction * speed * Time.fixedDeltaTime;

        }

    }
}

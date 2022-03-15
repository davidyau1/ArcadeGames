using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPlayer : PlayerControl
{
    // Start is called before the first frame update
   protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            direction.y = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direction.y = -1;
        }
        else
        {
            direction.y=0;
        }
    }
    private void FixedUpdate()
    {
        MovePlayer();
    }
    void MovePlayer()
    {

        rb.velocity = direction * speed * Time.fixedDeltaTime;

    }
}

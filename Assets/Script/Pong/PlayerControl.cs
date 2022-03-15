using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D rb;

    public GameObject Player;
    public float speed;
    public Vector3 direction;
    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


}

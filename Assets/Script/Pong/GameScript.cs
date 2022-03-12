using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public enum State
    {
        Play,
        GameOver,
        Pause

    }
    public float playerSpeed;
    public float ballSpeed;
    public int[] score;


    public GameObject ball;
    public GameObject leftPlayer;
    public GameObject rightPlayer;
    public GameObject topWall;
    public GameObject bottomWall;
    public GameObject leftGoal;
    public GameObject rightGoal;


    void BeginRound()
    {
        Instantiate(ball);

    }
    void ScorePoint()
    {
        Destroy(ball);
    }
    void Collision()
    {

    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}

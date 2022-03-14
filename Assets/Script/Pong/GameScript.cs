using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameScript : MonoBehaviour
{
    public enum GameState
    {
        Begin,
        Playing,
        GameOver,
        Pause

    }
    public float playerSpeed;
    public int[] score;
    public GameObject ballPrefab;
    public GameObject leftPlayer;
    public GameObject rightPlayer;
    public GameObject topWall;
    public GameObject bottomWall;
    public GameObject leftGoal;
    public GameObject rightGoal;
    public GameState state;


    void StartRound()
    {
        Instantiate(ballPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    void ScorePoint()
    {

    }
   



    // Start is called before the first frame update
    void Start()
    {
        if (true)
        {

        }
        StartRound();
    }



    // Update is called once per frame
    void Update()
    {
       
    }
}

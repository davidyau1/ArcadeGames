using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public static int leftScore;
    public static int rightScore;
    public GameObject ballPrefab;
    public GameObject leftPlayer;
    public GameObject rightPlayer;
    public GameObject topWall;
    public GameObject bottomWall;
    public GameObject leftGoal;
    public GameObject rightGoal;
    public GameState state;
    public Text leftScoreText;
    public Text rightScoreText;



    void StartRound()
    {
        Instantiate(ballPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    void ScorePoint(string side)
    {
        if (side=="left")
        {
            leftScore++;
        }
        if (side == "right")
        {
            rightScore++;
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        StartRound();
    }



    // Update is called once per frame
    void Update()
    {
        leftScoreText.text = "<color=white>"+leftScore.ToString()+"</color>";
        rightScoreText.text = "<color=white>" + rightScore.ToString() + "</color>";

    }
}

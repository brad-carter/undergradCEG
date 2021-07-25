using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
/**
* Brad Carter 
* 7/21/2021
* Wright State University
*/

    public GameObject Sphere;
    public GameObject ScoreText = null;
    private float x;
    private bool startFlag;
    Ball currentBall = null;
    ScoreTextScript score = null;
    

    // Start is called before the first frame update
    void Start()
    {
        // Ball currentBall;
        GameObject scoreText = GameObject.Find("ScoreText");
        GameObject sphere = GameObject.Find("Sphere");
        Ball ball = sphere.GetComponent<Ball>();
        ScoreTextScript scoreTextScript = scoreText.GetComponent<ScoreTextScript>();
        score = scoreTextScript;
        currentBall = ball;
        startFlag = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && !startFlag)
        {
            startFlag = true;
            currentBall.reset();
        }

        x = currentBall.x;
        if (x > 69)
        {
            givePoint(true);
        }

       if (x < -69)
       {
           givePoint(false);
       }
    }
    void givePoint(bool changeScore)
    {
        if (changeScore)
        {
            score.upScore();
        }
        else
        {
            score.downScore();
        }

        currentBall.reset();
    }
}

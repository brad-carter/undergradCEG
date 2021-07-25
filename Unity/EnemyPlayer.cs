/**
* Brad Carter 
* 7/21/2021
* Wright State University
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayer : MonoBehaviour
{
    public GameObject Sphere;
    Ball currentBall = null;

    private float zLoc, xLoc;
    private int enemyErr;


    // Start is called before the first frame update
    void Start()
    {
        GameObject sphere = GameObject.Find("Sphere");
        Ball ball = sphere.GetComponent<Ball>();
        currentBall = ball;
        xLoc = 67;
        zLoc = 1;
        enemyErr = 0;

    }

    // Update is called once per frame
    void Update()
    {
        enemyErr = (Random.Range(0, 2) * 2 - 1);
        if (currentBall.x > 0 && enemyErr > 0)
        {
            if (currentBall.z > zLoc)
            {
                zLoc += 0.02f;
            }
            else if (currentBall.z < zLoc)
            {
                zLoc -= 0.02f;
            }
        }
        

        transform.position = new Vector3(xLoc, 0, zLoc);


       
    }
}

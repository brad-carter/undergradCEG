/**
* Brad Carter 
* 7/21/2021
* Wright State University
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTextScript : MonoBehaviour
{
    private TMP_Text textMesh;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TMP_Text>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void upScore()
    {
        score++;
        textMesh.text = ("Score: " + score.ToString());
    }

    public void downScore()
    {
        score--;
        textMesh.text = ("Score: " + score.ToString());

    }
}

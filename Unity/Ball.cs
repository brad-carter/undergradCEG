/**
* Brad Carter 
* 7/21/2021
* Wright State University
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Ball : MonoBehaviour
{
    private float xChange, zChange;
    public float x, y, z;
        
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
        void FixedUpdate()
    {
        
        x += xChange;

        if (z > 42 || z < -42)
        {
            zChange = zChange * -1.0f;
            z += zChange;
        }
        else
        {
            z += zChange;
        }

        transform.position = new Vector3(x, y, z);
    }

    void OnCollisionEnter(Collision collision)
    {
        xChange = xChange * -1.0f;
        xChange += 0.1f;
        
        zChange = 0.1f * (float)((Random.Range(0.1f, 0.8f) * 2) * (Random.Range(0, 2) * 2 - 1));
    }


    public void reset()
    {
        x = 0;
        y = 0;
        z = 0;
        xChange = 0.0f;
        zChange = 0.0f;
        readyStart();

    }

    public void readyStart()
    {
        xChange = 0.9f;
        xChange = xChange*(Random.Range(0.0f, 2.0f) * 2 - 1);
    }

    
}

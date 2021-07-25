/**
* Brad Carter 
* 7/21/2021
* Wright State University
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int input;
    private float zLoc, xLoc;
    // Start is called before the first frame update
    void Start()
    {
        xLoc = -67;
        zLoc = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("down") && (zLoc - 0.1f) > -42)
        {
            zLoc -= 0.1f;
        } 
        
        if (Input.GetKey("up") && (zLoc+0.1f) < 42)
        {
            zLoc += 0.1f;
        }

        
            transform.position = new Vector3(xLoc, 0, zLoc);
        
        
    }
}

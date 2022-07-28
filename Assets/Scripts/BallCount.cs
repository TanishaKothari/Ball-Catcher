using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCount : MonoBehaviour
{
    private void Start()
    {
        gameObject.tag = "Ball";
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Glove")
        {
            Destroy(gameObject);
            Score.scoreValue += 1;
        }
        else if(other.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
} //class

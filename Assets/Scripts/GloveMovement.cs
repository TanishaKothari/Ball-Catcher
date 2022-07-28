using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GloveMovement : MonoBehaviour
{
    public float speed = 3.0f;

    private Rigidbody2D gloveRigid;

    private void Start()
    {
        gloveRigid = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.position -= transform.right * speed * Time.deltaTime;
            gloveRigid.velocity = new Vector2(-speed, 0) * speed * Time.deltaTime;
        }

        else
        {
            gloveRigid.velocity = new Vector2(0, 0) * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.position += transform.right * speed * Time.deltaTime;
            gloveRigid.velocity = new Vector2(speed, 0) * speed * Time.deltaTime;
        }
    }
} //class

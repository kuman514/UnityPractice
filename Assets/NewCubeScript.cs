using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCubeScript : MonoBehaviour
{
    Rigidbody rb;
    int jumpCount;
    bool isGround;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpCount = 1;
        isGround = true;
    }

    // Update is called once per frame
    void Update()
    {
        // check the object on the ground first
        if(isGround)
        {
            jumpCount = 1;

            // and then check the spacekey pressed
            if(Input.GetKeyDown("space"))
            {
                if(jumpCount == 1)
                {
                    rb.AddForce(0, 300f, 0);
                    isGround = false;
                    jumpCount = 0;
                }
            }
        }

        // moving up down left and right
        if (Input.GetKey("up"))
        {
            transform.position += new Vector3(0, 0, 0.01f);
        }

        if (Input.GetKey("down"))
        {
            transform.position += new Vector3(0, 0, -0.01f);
        }

        if (Input.GetKey("left"))
        {
            transform.position += new Vector3(-0.01f, 0, 0);
        }

        if (Input.GetKey("right"))
        {
            transform.position += new Vector3(0.01f, 0, 0);
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        // if the cube is on the floor...
        if(col.gameObject.tag == "floor")
        {
            isGround = true;
            jumpCount = 1;
        }
    }
}

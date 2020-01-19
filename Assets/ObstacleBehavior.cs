using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-4.5f, 4.5f), 0, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, -0.05f);
        if(transform.position.z < -10f)
        {
            // Reset Position
            transform.position = new Vector3(Random.Range(-4.5f, 4.5f), 0, 10f);
        }
    }
}

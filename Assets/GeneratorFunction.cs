using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Generate());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Generate()
    {
        Instantiate(ObstacleBehavior.obj, new Vector3(Random.Range(-4.5f, 4.5f), 0, 10), Quaternion.identity);
        yield return new WaitForSeconds(5);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DdestroyOutOfBound : MonoBehaviour
{
    private float topBoundary = 30;
    private float lowerBoundary = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBoundary) // destroys object when they cross top screen boundary
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBoundary)  // destroys object when they cross lower screen boundary
        {
            Destroy(gameObject);
        }
    }
}

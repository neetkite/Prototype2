using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    // Start is called before the first frame update
    private float topBound = 34.0f;
    private float bottomBound = -15.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound) Destroy(gameObject);
        else if(transform.position.z < bottomBound) Destroy(gameObject);
    }
}

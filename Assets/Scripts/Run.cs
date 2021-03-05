using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * 0.1f;

        if (transform.position.z > 2600)
        {
            transform.position = new Vector3(0, -1.500004f, -9);
            
        }
    }
}

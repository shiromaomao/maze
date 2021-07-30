using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public int moveX = 0;
    public int moveY = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Physics.gravity);//0,-9.8,0
    }

    // Update is called once per frame
    void Update()
    {
        Physics.gravity = Vector3.up * 5;//反重力

        /*int moveX = Random.Range(0, 1);
        int moveY = Random.Range(0, 1);

        if ()
        {
            transform.position += transform.forward * 0.05f;
        }


        if (Input.GetKey("down") || Input.GetKey("s"))
        {
            transform.position -= transform.forward * 0.01f;
        }

        if (Input.GetKey("a"))
        {
            transform.position -= transform.right * 0.05f;
        }

        if (Input.GetKey("d"))
        {
            transform.position += transform.right * 0.05f;
        }*/
    }
}

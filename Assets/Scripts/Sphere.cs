using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    Rigidbody rb1;
    // Start is called before the first frame update
    void Start()
    {
        rb1 = GetComponent<Rigidbody>();
        rb1.AddForce(10,0,0,ForceMode.Impulse);//speed

        GameObject original = GameObject.Find("Sphere");
		GameObject copied = Object.Instantiate(original) as GameObject;
		copied.transform.Translate(-25,30,-8);
    }

    //public static Object Instantiate(Object original, Vector3 position, Quaterinon rotation);

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -12)//hukki
        {
            transform.position = new Vector3(-25,29,-7);
        }
    }
}

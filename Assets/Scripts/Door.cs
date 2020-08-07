using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int openkeynum;

    void Start()
    {
     
    }

    public void Open()
    {
        //ドアを消す
        Destroy (this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlopeController : MonoBehaviour
{
    // Start is called before the first frame update

    public Player player;
    public Vector3 angle;
    void  Start()
    {
        angle = transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.pushedSwich)
        {
            angle.x = 14;   
        }
         else
        {
            angle.x = -12.5f;    
        }
        transform.localEulerAngles = angle;
    }
}

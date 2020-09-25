using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitplayer : MonoBehaviour
{
    public static bool call;//静的変数（値が保持され続ける）

    // Start is called before the first frame update
    void Start()
    {
        call = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider col) 
    {
        if (col.gameObject.tag == "Player")
        {
　　        call = true;
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log(transform.position);
        Debug.Log(transform.forward);
        transform.position += transform.forward * 0.02f;

    }
}

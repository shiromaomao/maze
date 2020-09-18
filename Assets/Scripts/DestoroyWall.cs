using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoroyWall : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Sphere"))// もしもぶつかってきたオブジェクトのタグに(Sphere)という名前がついていたら
        {
            Destroy(other.gameObject);// ぶつかってきたオブジェクトを破壊（削除）する
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

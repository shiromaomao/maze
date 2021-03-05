using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoroyWall : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // もしもぶつかってきたオブジェクトのタグに(Sphere)または、(Rain)という名前がついていたら
        if(other.CompareTag("Sphere") || other.CompareTag("Rain"))
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

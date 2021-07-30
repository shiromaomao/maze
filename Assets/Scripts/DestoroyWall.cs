using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoroyWall : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // もしもぶつかってきたオブジェクトのタグに(Sphere)または、(Rain)または、(Bubble)という名前がついていたら
        Debug.Log("touch");
        if (other.CompareTag("Sphere") || other.CompareTag("Rain") || other.CompareTag("Bubble"))
        {
            Debug.Log("Destory");
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

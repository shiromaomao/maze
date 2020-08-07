using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road_to_Gool : MonoBehaviour
{
    Rigidbody rb;

    bool m_yPlus = true; //x軸の＋方向に移動中か？
    //scrtchでいう0か1か（正か負か)
    
    // Start is called before the first frame update

    void Start() 
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine("Paineapple");
    }
    IEnumerator Paineapple() //voidは、return値がない型
    {   
        while(true)
        {
        StartCoroutine("stop4");
           //  private IEnumerator stop()  を呼び出す
        yield return new WaitForSeconds(3.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private IEnumerator stop4() //コルーチン関数の名前
    　　　　//  StartCoroutine("stop");  の中身
    {
        //コルーチンの内容
         yield return new WaitForSeconds(5.0f);
      while( m_yPlus )　//trueの間波括弧の中を繰り返す
      {
          rb.velocity = new Vector3(0,2,0);
          
　　　　　　yield return new WaitForSeconds(0.05f);
          if( transform.position.y >= 40)
          {
            yield return new WaitForSeconds(5.0f);
            transform.position = new Vector3(-29,25.75f,-8);
          } 
      }
    }
}
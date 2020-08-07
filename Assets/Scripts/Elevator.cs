using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{ 
    Rigidbody rb;
    bool m_yPlus = true; //x軸の＋方向に移動中か？@
        //scrtchでいう0か1か（正か負か)
    
    // Start is called before the first frame update
      void Start() 
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine("Pear");
    }
    IEnumerator Pear() //voidは、return値がない型
    {   
        while(true)
        {
        StartCoroutine("stop");
           //  private IEnumerator stop()  を呼び出す
        yield return new WaitForSeconds(3.0f);
        }
    }
    // Update is called once per frame
    void Update()
    {
　　　 
    }
    
     //IEnumeratorの関数でコルーチンの内容を作成し、StartCoroutineメソッドで実行する。
     //コルーチン関数を定義
    private IEnumerator stop() //コルーチン関数の名前
    　　　　//  StartCoroutine("stop");  の中身
    {
        //コルーチンの内容
         yield return new WaitForSeconds(5.0f);
      while( m_yPlus )　//trueの間波括弧の中を繰り返す
      {
          
           rb.velocity = new Vector3(0,0.125f,0);
　　　　　　yield return new WaitForSeconds(0.05f);
          if( transform.position.y >= 2 )
          {
              m_yPlus = false;

            yield return new WaitForSeconds(5.0f);
          } 
      }
      while( m_yPlus == false )　//falseの間波括弧の中を繰り返す
      {
          rb.velocity = new Vector3(0,0.25f,0);

          if( transform.position.y <= -46 )
          {    m_yPlus = true;

            yield return new WaitForSeconds(5.0f);
          }  
      }
    }//rigidbodyにすべて変える
}

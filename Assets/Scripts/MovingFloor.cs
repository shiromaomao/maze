using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFloor : MonoBehaviour
{
    Rigidbody rb;
  bool m_xPlus = true; //x軸の＋方向に移動中か？@
        //scrtchでいう0か1か（正か負か)
    
    // Start is called before the first frame update

    void Start() 
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine("Apple");
    }
    IEnumerator Apple() //voidは、return値がない型
    {   
        while(true)
        {
        StartCoroutine("stop1");
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
    private IEnumerator stop1() //コルーチン関数の名前
    　　　　//  StartCoroutine("stop");  の中身
    {
        //コルーチンの内容
         yield return new WaitForSeconds(5.0f);

      while( m_xPlus )　//trueの間波括弧の中を繰り返す
      {
          rb.velocity = new Vector3(4,0,0);
　　　　　 yield return new WaitForSeconds(0.05f);
          
        
          if( transform.position.x >= 31 )
          {
                m_xPlus = false;
                yield return new WaitForSeconds(15.0f);
          } 
      }
      while( m_xPlus == false )　//falseの間波括弧の中を繰り返す
      {
          rb.velocity = new Vector3(-12,0,0);
          yield return new WaitForSeconds(1.0f);//(0.05f);
          
          if( transform.position.x <= -0.3f )
          {    
                m_xPlus = true;
                yield return new WaitForSeconds(15.0f);
          }  
      }
    }
}

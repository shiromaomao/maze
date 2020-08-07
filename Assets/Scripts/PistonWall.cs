using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonWall : MonoBehaviour
{
 bool m_xPlus = true; //x軸の＋方向に移動中か？@
        //scrtchでいう0か1か（正か負か)
    
    // Start is called before the first frame update
    IEnumerator Start() //voidは、return値がない型
    {   
        while(true)
        {
        StartCoroutine("stop3");
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
    private IEnumerator stop3() //コルーチン関数の名前
    　　　　//  StartCoroutine("stop");  の中身
    {
        //コルーチンの内容
         yield return new WaitForSeconds(5.0f);

      while( m_xPlus )　//trueの間波括弧の中を繰り返す
      {
          transform.position += new Vector3(0.125f,0f,0f);
　　　　　 yield return new WaitForSeconds(0.05f);
          
          if( transform.position.x >= 8.5f )
          {
                m_xPlus = false;
                yield return new WaitForSeconds(5.0f);
          } 
      }
      while( m_xPlus == false )　//falseの間波括弧の中を繰り返す
      {
          transform.position -= new Vector3(0.125f,0f,0f);
          yield return new WaitForSeconds(0.05f);
          
          if( transform.position.x <= 1.5f )
          {    
                m_xPlus = true;
                yield return new WaitForSeconds(5.0f);
          }  
      }
    }
}

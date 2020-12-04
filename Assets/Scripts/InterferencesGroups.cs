using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterferencesGroups : MonoBehaviour
{
 bool m_yPlus = true; //x軸の＋方向に移動中か？@
        //scrtchでいう0か1か（正か負か)
    
    // Start is called before the first frame update
    IEnumerator Start() //voidは、return値がない型
    {   
        while(true)
        {
        StartCoroutine("updown");
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
    private IEnumerator updown() //コルーチン関数の名前
    {
        //コルーチンの内容
         yield return new WaitForSeconds(5.0f);

      while( m_yPlus )　//trueの間波括弧の中を繰り返す
      {
          transform.position += new Vector3(0f,0.1f,0f);
　　　　　 yield return new WaitForSeconds(0.05f);
          
          if( transform.position.y >= 29.1f )
          {
                m_yPlus = false;
                yield return new WaitForSeconds(5.0f);
          } 
      }
      while( m_yPlus == false )　//falseの間波括弧の中を繰り返す
      {
          transform.position -= new Vector3(0f,0.1f,0f);
          yield return new WaitForSeconds(0.05f);
          
          if( transform.position.y <= 27.1f )
          {    
                m_yPlus = true;
                yield return new WaitForSeconds(5.0f);
          }  
      }
    }
}

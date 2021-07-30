using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blind : MonoBehaviour
{
    float BlindCount = 14;

    //private bool BT;//BlindTiming
    //上下からガシャーン（Z方向）

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
  /*  void Update()//////////////その場にとどまり続けてワープされないバグの解消
    {
        BlindCount -= Time.deltaTime;
        if(BlindCount <= 0)
        {
            StartCoroutine("BlindT");
        }

        if(transform.position.z > 0)//z座標が0以上。つまり、Blind
        {
            transform.position -= new Vector3(0f, 0f, 0.025f);
        }
        else//z座標が0以下。つまり、Blind1
        {
            transform.position += new Vector3(0f, 0f, 0.025f);
        }

        if (transform.position.z == 0)//&& transform.position.z > -0.5f)
        {
            transform.position = new Vector3(0, 0.8f, 2);
        }

    }
    
    private IEnumerator BlindT() //コルーチン関数の名前   StartCoroutine("Blind");  の中身
    {
        //コルーチンの内容
        while (true)
        {
            Move();
            yield return new WaitForSeconds(2.0f);//()秒待つ
        }
    }

    void Move()
    {
        int z = Random.Range(-14, 0);//-14以上で、0より下の整数（つまり、-1）の間の値を返す

        GameObject copied = Object.Instantiate(original) as GameObject;//oliginalをcopiする
        copied.transform.Translate(-25, 30, z);//copiの出てくる場所を(x=-25,y=30,z=-6~7)とする
    }*/
}
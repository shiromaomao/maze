using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sphere : MonoBehaviour
{
    public int count = 0;//クローン調整用
    public GameObject original;

    Rigidbody rb1;//Rigidbodyを、rb1とする。
    // Start is called before the first frame update
    void Start()
    {
        rb1 = GetComponent<Rigidbody>();
        rb1.AddForce(10, 0, 0, ForceMode.Impulse);//speed
    }

    // Update is called once per frame
    void Update()
    {
        if (Hitplayer.call == true)
        {
            Debug.Log("out");
            StartCoroutine("Clone2");
            //InvokeRepeating("Clone", 5, 10);
            Hitplayer.call = false;
        }

        if (transform.position.y < -12)//delete
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator Clone2() //コルーチン関数の名前   StartCoroutine("Clone2");  の中身
    {
        //コルーチンの内容
        while (true)
        {
            Clone();
            yield return new WaitForSeconds(2.0f);//()秒待つ
        }
    }

    void Clone()
    {
        int z = Random.Range(-14, 0);//-14以上で、0より下の整数（つまり、-1）の間の値を返す

        GameObject copied = Object.Instantiate(original) as GameObject;//oliginalをcopiする
        copied.transform.Translate(-25, 30, z);//copiの出てくる場所を(x=-25,y=30,z=-6~7)とする
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainy : MonoBehaviour
{
    public int count = 0;//クローン調整用
    public GameObject original1;

    Rigidbody rb1;//Rigidbodyを、rb1とする。
    // Start is called before the first frame update
    void Start()
    {
        rb1 = GetComponent<Rigidbody>();
        rb1.AddForce(0, 10, 0, ForceMode.Impulse);//speed

        StartCoroutine("Clone2");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position.y);
        if (transform.position.y < -30)//delete
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
            yield return new WaitForSeconds(0.1f);//()秒待つ
        } 
    }

    void Clone()
    {
        int x = Random.Range(-100, 100);//-100以上で、100より下の整数(つまり、99)の間の値を返す(以上,未満)
        int z = Random.Range(-100, 100);//-100以上で、100より下の整数(つまり、99)の間の値を返す(以上,未満)

        GameObject copied = Object.Instantiate(original1) as GameObject;//oliginalをcopiする
        copied.transform.Translate(x, 100, z);//copiの出てくる場所を(x=-100~100,y=100,z=-100~100)とする
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sphere : MonoBehaviour
{
    public int count = 0;//クローン調整用

    Rigidbody rb1;
    // Start is called before the first frame update
    void Start()
    {
        rb1 = GetComponent<Rigidbody>();
        rb1.AddForce(10,0,0,ForceMode.Impulse);//speed

        /*GameObject original = GameObject.Find("Sphere");
		GameObject copied = Object.Instantiate(original) as GameObject;
		copied.transform.Translate(-25,30,);*/
    } 
    //public static Object Instantiate(Object original, Vector3 position, Quaterinon rotation);

    
    IEnumerator Pear() //voidは、return値がない型
    {   
        if(count == 0)
        {
　 　       StartCoroutine("stay");//  private IEnumerator stay()  を呼び出す
            yield return new WaitForSeconds(3.0f);
        }
    }
    private IEnumerator stay()//コルーチン関数の名前
    {
        yield return new WaitForSeconds(2.0f);//2秒待つ

        int z = Random.Range (-6,8);//-6以上で、8より下の整数（つまり、7）の間の値を返す

        GameObject original = GameObject.Find("Sphere");//Sphereをoriginalとする
        GameObject copied = Object.Instantiate(original) as GameObject;//oliginalをcopiする
	    copied.transform.Translate(-25,30,z);//copiの出てくる場所を(x=-25,y=30,z=-6~7)とする

    } 
   

    // Update is called once per frame
    void Update()
    {   
        if(transform.position.y < -12)//hukki
        {
            transform.position = new Vector3(-25,29,-7);
        }
    }
}

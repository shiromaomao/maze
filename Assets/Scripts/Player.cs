using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour {
    // Start is called before the first frame update

    public Text scoreText; //Text用変数

    public bool pushedSwich;

    void Start() 
    {
        pushedSwich = false;
      scoreText.text = "Key: 0"; //初期スコアを代入して表示
    }
    int Keyget = 0;

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKey("up")) 
        {
            transform.position += transform.forward * 0.1f;
        }

        if (Input.GetKey("right")) 
        {
            transform.Rotate(0, 5, 0);
        }

        if(Input.GetKey("left")) 
        {
            transform.Rotate(0, -5, 0);
        }

        if (Input.GetKey("down"))
        {
            transform.position -= transform.forward * 0.1f;
        }
        //andと、orの方法がわからないから一旦放置。とりま、完成目指す！！
        if(transform.position.y < -60) //or (Input.GetKey("S"))
        {
            transform.position = new Vector3(8.3f,2,8.5f);
            //transform.rotation = (new Vector3(0,-90,0));
        }
        
        scoreText.text = "Key:" + Keyget;

    }

    private void OnCollisionEnter(Collision col)
    {
         //Door
        if (col.gameObject.tag == "Door")
        {
            if (Keyget >= col.gameObject.GetComponent<Door>().openkeynum)
            {
                Keyget -= col.gameObject.GetComponent<Door>().openkeynum;
                col.gameObject.GetComponent<Door>().Open();
            }
        }

        //Ereveter
        if (col.gameObject.tag == "Elevator")
        {
            /*if (Keyget >= col.gameObject.GetComponent<Door>().openkeynum)
            {
                Keyget -= col.gameObject.GetComponent<Door>().openkeynum;
                col.gameObject.GetComponent<Door>().Open();
            }*/
            
            //「=」は、1つで代入。2つで等価。
            this.gameObject.transform.parent = col.gameObject.transform;
        }

        if (col.gameObject.tag == "Switch" && !pushedSwich) //&&　で、「かつ」。　
        //!は、「bool」型の値を反転（否定）　例）！＝で、「異なるなら」となる。
        {
            pushedSwich = true; 
            StartCoroutine("stop3");
        }                
    }
    private IEnumerator stop3() //コルーチン関数の名前
    　　　　//  StartCoroutine("stop3");  の中身
    {
        //コルーチンの内容
         yield return new WaitForSeconds(15.0f);//5秒待つ
         pushedSwich = false;
    }
    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Elevator")
        {
            /*if (Keyget >= col.gameObject.GetComponent<Door>().openkeynum)
            {
                Keyget -= col.gameObject.GetComponent<Door>().openkeynum;
                col.gameObject.GetComponent<Door>().Open();
            }*/
            this.gameObject.transform.parent = null;
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "key")
        {
            Destroy(col.gameObject);
            ++Keyget;
        }

       
    }

}

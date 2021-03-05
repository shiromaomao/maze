using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    public Text scoreText; //Text用変数

    public bool pushedSwich;

    int memorycollect = 0;//memoryの数//memorycollectの数える仕組みは、一番下に

    int Keyget = 0;
    void Start()
    {
        pushedSwich = false;
        scoreText.text = "Key: 0"; //初期スコアを代入して表示
    }
    // Update is called once per frame

    void Update()
    {
        //移動＆回転関係
        if (Input.GetKey("up") || Input.GetKey("w"))
        {
            transform.position += transform.forward * 0.1f;
        }


        if (Input.GetKey("down") || Input.GetKey("s"))
        {
            transform.position -= transform.forward * 0.1f;
        }

        if (Input.GetKey("a") )
        {
            transform.position -= transform.right * 0.1f;
        }

        if (Input.GetKey("d") )
        {
            transform.position += transform.right * 0.1f;
        }

        if (Input.GetKey("left") || Input.GetKey("q"))
        {
            transform.Rotate(0, -5, 0);
        }
        
        if (Input.GetKey("right") || Input.GetKey("e"))
        {
            transform.Rotate(0, 5, 0);
        }


        if (transform.position.y < -60)
        {
            transform.position = new Vector3(8.3f, 2, 8.5f);
            float y = -90;
            this.transform.rotation = Quaternion.Euler(0.0f, y, 0.0f);
        }

        if (Input.GetKey("r"))
        {
            transform.position = new Vector3(8.3f, 2, 8.5f);
            float y = -90;
            this.transform.rotation = Quaternion.Euler(0.0f, y, 0.0f);
        }

        scoreText.text = "Key:" + Keyget;
    }

    private void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name); // ぶつかった相手の名前を取得
        //妨害関係
        if (col.gameObject.tag == "Sphere")
        {
            transform.position = new Vector3(42, 20, -8);
            float y = -90;
            this.transform.rotation = Quaternion.Euler(0.0f, y, 0.0f);
        }

        if (col.gameObject.tag == "Enemy")
        {
            transform.position = new Vector3(8.3f, 2, 8.5f);
            float y = -90;
            this.transform.rotation = Quaternion.Euler(0.0f, y, 0.0f);
        }
        //Door
        if (col.gameObject.tag == "Door")
        {       
            if (Keyget >= col.gameObject.GetComponent<Door>().openkeynum)
            {
                Keyget -= col.gameObject.GetComponent<Door>().openkeynum;
                col.gameObject.GetComponent<Door>().Open();
            }
        }

        if (col.gameObject.tag == "Switch" && !pushedSwich) //&&　で、「かつ」。　
        //!は、「bool」型の値を反転（否定）　例）！＝で、「異なるなら」となる。
        {
            pushedSwich = true;
            StartCoroutine("stop3");
        }
    }

    private IEnumerator stop3() //コルーチン関数の名前  StartCoroutine("stop3");  の中身
    {
        yield return new WaitForSeconds(15.0f);//5秒待つ
        pushedSwich = false;
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Elevator")
        {
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
        
        if (col.gameObject.tag == "Memory Tip")
        {
            Destroy(col.gameObject);
            ++memorycollect;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour {
    // Start is called before the first frame update

    public Text scoreText; //Text用変数

    void Start() 
    {
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
        if (col.gameObject.tag == "Ereveter")
        {
            if (Keyget >= col.gameObject.GetComponent<Door>().openkeynum)
            {
                Keyget -= col.gameObject.GetComponent<Door>().openkeynum;
                col.gameObject.GetComponent<Door>().Open();
            }
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

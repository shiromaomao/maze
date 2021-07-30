using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubbleclone : MonoBehaviour
{
    //BubbleClone
    //SoundEfect(Bubble)

    AudioSource audioSource; //AudioSourceの変数を作成する
    public AudioClip BSE1; //泡単音
    public AudioClip BSE2; //沈んでいく（短）

    public int count = 0;//クローン調整用

    public GameObject original;//objectは一個のみ

    public int oq = 50;//酸素量 OxygenQuantityの略

    public int Getoq()//他のオブジェクトでも変数を取得できるようにするため
    {
        return oq;
    }

    //BIGが出すぎるため
    int AdO = 0;//調整　Adjustmentの略

    public GameObject[] originals = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Bubble");

        audioSource = GetComponent<AudioSource>();  //AudioSourceを使えるようにする
    }
    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator Bubble() //コルーチン関数の名前   StartCoroutine("Bubble");  の中身
    {
        //コルーチンの内容
        while (true)
        {
            if (oq <= 0) break;//OxygenQuantity <= 0なら、ループから抜ける

            yield return new WaitForSeconds(0.35f);//()秒待つ
            BubbleClone();
            Debug.Log(oq);
        }
    }

    void BubbleClone()    
    {
        int x = Random.Range(-5, 6);//(a,b)  -a以上で、bより下の整数（つまり、b-1）の間の値を返す
        int z = Random.Range(-5, 6);
        int BubbleSize = Random.Range(0, originals.Length);

        GameObject copied = Object.Instantiate(originals[BubbleSize]) as GameObject;//gameObjectをcopiする//配列のため[]がいる
        copied.transform.position = new Vector3(x, -5, z);//copiの出てくる場所を(x,y,z)とする
        //x -5～5 y -5 z -3～3
        
        if (BubbleSize == 0)
        {
            oq -= 1;
            audioSource.PlayOneShot(BSE2); //BSE2を鳴らす

        }
        
        if (BubbleSize == 1)
        {
            oq -= 3;
            audioSource.PlayOneShot(BSE2); //BSE2を鳴らす
        }
        
        //BIGが出すぎるため↑↑↑61で生成
        if (BubbleSize == 2)
        {
            AdO += 1;
            if (AdO == 50)//意味ない
            {
                AdO = 0;
                oq -= 5;
                audioSource.PlayOneShot(BSE1); //BSE1を鳴らす
            }
        }
    }
}

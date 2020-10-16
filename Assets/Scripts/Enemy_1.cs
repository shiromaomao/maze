using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : MonoBehaviour
{
    public Transform E1T;
    bool m_zPlus = true; //z軸の＋方向に移動中か？

    // Start is called before the first frame update
    void Start()
    {
        E1T = this.gameObject.GetComponent<Transform>();// グローバル変数E1Tへ入れる

    }

    // Update is called once per frame
    void Update()
    {
        while (m_zPlus)
        {
            Debug.Log(transform.position);
            Debug.Log(transform.forward);
            transform.position += transform.forward * 0.05f;//0.02

            if (E1T.position.z == 5)
            {
                m_zPlus = false;

            }
        }
        while (m_zPlus == false)
        {
            Debug.Log(transform.position);
            Debug.Log(transform.forward);
            transform.position += transform.forward * -0.05f;//-0.02

            if (E1T.position.z ==　-8)
            {
                m_zPlus = true;

            }
        }

    }
}

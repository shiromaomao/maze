using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blind : MonoBehaviour
{
    float BlindCount = 14;

    //private bool BT;//BlindTiming
    //�㉺����K�V���[���iZ�����j

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
  /*  void Update()//////////////���̏�ɂƂǂ܂葱���ă��[�v����Ȃ��o�O�̉���
    {
        BlindCount -= Time.deltaTime;
        if(BlindCount <= 0)
        {
            StartCoroutine("BlindT");
        }

        if(transform.position.z > 0)//z���W��0�ȏ�B�܂�ABlind
        {
            transform.position -= new Vector3(0f, 0f, 0.025f);
        }
        else//z���W��0�ȉ��B�܂�ABlind1
        {
            transform.position += new Vector3(0f, 0f, 0.025f);
        }

        if (transform.position.z == 0)//&& transform.position.z > -0.5f)
        {
            transform.position = new Vector3(0, 0.8f, 2);
        }

    }
    
    private IEnumerator BlindT() //�R���[�`���֐��̖��O   StartCoroutine("Blind");  �̒��g
    {
        //�R���[�`���̓��e
        while (true)
        {
            Move();
            yield return new WaitForSeconds(2.0f);//()�b�҂�
        }
    }

    void Move()
    {
        int z = Random.Range(-14, 0);//-14�ȏ�ŁA0��艺�̐����i�܂�A-1�j�̊Ԃ̒l��Ԃ�

        GameObject copied = Object.Instantiate(original) as GameObject;//oliginal��copi����
        copied.transform.Translate(-25, 30, z);//copi�̏o�Ă���ꏊ��(x=-25,y=30,z=-6~7)�Ƃ���
    }*/
}
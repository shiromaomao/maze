using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehaviour
    {
        //コピペ
    public float speed = 0.5f;
    public float rotationspeed = 1f;
    public float posrange = 3f;
    private Vector3 targetpos;
    private float changetarget = 5f;
    public GameObject player;
    public float targetdistance;
    public float distancetoplayer;
        Vector3 GetRandomPosition(Vector3 currentpos)
        {
            return new Vector3(Random.Range(-posrange + currentpos.x, posrange + currentpos.x), 1.5f, Random.Range(-posrange + currentpos.z, posrange + currentpos.z));
        }

        void haikai()
        {
            if (targetdistance < changetarget) targetpos = GetRandomPosition(transform.position);
            Quaternion targetRotation = Quaternion.LookRotation(targetpos - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationspeed);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            Debug.Log("haikai");
        }

        void chase()
        {
            Quaternion playerRotation = Quaternion.LookRotation(player.transform.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, playerRotation, Time.deltaTime * rotationspeed * 10f);
            transform.Translate(Vector3.forward * speed * 3f * Time.deltaTime);
            Debug.Log("chase");
        }

        void attack()
        {
            Debug.Log("attack");
        }

        void Start()
        {
            targetpos = GetRandomPosition(transform.position);
        }


        /*
        void Update()
        {
            targetdistance = Vector3.SqrMagnitude(transform.position - targetpos);
            distancetoplayer = Vector3.SqrMagnitude(transform.position - player.transform.position);
            if (distancetoplayer > 70f) haikai();
            else if (3f < distancetoplayer && distancetoplayer < 70f) chase();
            else attack();
        }
        void Update()
    {
        this.gameObject.transform.position += this.gameObject.transform.forward * 3.1f;
    }

        void FixedUpdate () 
        {
            Rigidbody rb = this.GetComponent<Rigidbody> ();
            Vector3 now = rb.position;  // 座標を取得
            now += new Vector3 (0.0f,0.0f,0.05f); 
            rb.position = now; 
    
 
    } */
}

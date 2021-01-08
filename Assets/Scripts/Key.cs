using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{   /*B2  括弧は扉（goalに行くやつは色変える）　 goal=Elevator 
        括弧の中の数は開けるのに必要な鍵の数
        空中迷路に必要な鍵の数　＝　８　ー　７（空中迷路で手に入る数）　＝　１
     ________________________________________________
     l                        l                     l
     l                        l                     l
     l     ****              {4}     ***  ***       l
     l_______{5}_____         l                     l
     l               L__{2}___L_______{3}___________l
     l               l *****  l                     l
     l     goal     {8}      {5}       **           l
     l               l        l                     l
     ------------------------------------------------
       2,4=red  3=grean  5=brack   */
    //Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(5f, 0f, 0f);
    }
}

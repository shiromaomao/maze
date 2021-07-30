using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class SceneReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, -9.8f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        /*Scene scene = SceneManager.GetActiveScene();

        Debug.Log(SceneManager.GetActiveScene().name);

        if ()
        {
            
        }*/
    }
}

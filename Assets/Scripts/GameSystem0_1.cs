using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSystem0_1 : MonoBehaviour
{
    //　スタートボタンを押したら実行する
    public void WakeUp()
    {
        Debug.Log("ugoita");
        SceneManager.LoadScene("Startting");
    }
}


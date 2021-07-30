using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    float testCount =20;

    //�@�X�^�[�g�{�^��������������s����
    public void WakeUp()
    {
        Debug.Log("GameStart");
        SceneManager.LoadScene("Meiro");
    }

    private void Update()
    {
        testCount -= Time.deltaTime;
        if (testCount <= 0)
        {
            Debug.Log("OP");
            SceneManager.LoadScene("Startting");
        }
    }
}


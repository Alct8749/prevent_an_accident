using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return; //Player가 아니면 실행 하지 않음
        Scene currScene = SceneManager.GetActiveScene(); //현재 씬 정보 획득
        switch (currScene.name)
        {
            case "MainScene":
                SceneManager.LoadScene("테크노Scene"); break;
            case "테크노Scene":
                SceneManager.LoadScene("MainScene"); break;
        }
    }
}
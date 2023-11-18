using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private UnityEvent onCollide;
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return; //Player가 아니면 실행 하지 않음
        onCollide?.Invoke();
        Invoke("nextScene", 1);
    }


    void nextScene()
    {
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
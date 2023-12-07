using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ChangeScene2 : MonoBehaviour
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
                GameManager.instance.isEnterCheck = true;
                SceneManager.LoadScene("디지털관Scene"); break;
            case "디지털관Scene":
                SceneManager.LoadScene("MainScene"); break;
        }
    }
}

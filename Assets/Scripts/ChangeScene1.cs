using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ChangeScene1 : MonoBehaviour
{
    [SerializeField] private UnityEvent onCollide;
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return; //Player�� �ƴϸ� ���� ���� ����
        onCollide?.Invoke();
        Invoke("nextScene", 1);
    }


    void nextScene()
    {
        Scene currScene = SceneManager.GetActiveScene(); //���� �� ���� ȹ��
        switch (currScene.name)
        {
            case "MainScene":
                GameManager.instance.isEnterCheck = true;
                SceneManager.LoadScene("��ũ��Scene"); break;
            case "��ũ��Scene":
                SceneManager.LoadScene("MainScene"); break;
        }
    }
}

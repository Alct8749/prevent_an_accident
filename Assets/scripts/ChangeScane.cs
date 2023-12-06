using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class ChangeScene1 : MonoBehaviour
{
    [SerializeField] private UnityEvent onCollide;
    private void OnTriggerEnter1(Collider other)
    {
        if (!other.CompareTag("Player")) return; //Player�� �ƴϸ� ���� ���� ����
        onCollide?.Invoke();
        Invoke("nextScene", 1);
    }


    void nextScene1()
    {
        Scene currScene = SceneManager.GetActiveScene(); //���� �� ���� ȹ��
        switch (currScene.name)
        {
            case "MainScene":
                SceneManager.LoadScene("��ũ��Scene"); break;
            case "��ũ��Scene":
                SceneManager.LoadScene("MainScene"); break;
        }
    }

}
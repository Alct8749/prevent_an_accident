using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return; //Player�� �ƴϸ� ���� ���� ����
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRestart : MonoBehaviour
{
    public void RestartScene()
    {
        // ���� ���� �ε����� �����ɴϴ�.
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // ���� ���� �ٽ� �ε��Ͽ� ������մϴ�.
        SceneManager.LoadScene(currentSceneIndex);
    }
}

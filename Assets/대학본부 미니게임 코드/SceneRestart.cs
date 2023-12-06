using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRestart : MonoBehaviour
{
    public void RestartScene()
    {
        // 현재 씬의 인덱스를 가져옵니다.
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // 현재 씬을 다시 로드하여 재시작합니다.
        SceneManager.LoadScene(currentSceneIndex);
    }
}

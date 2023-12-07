using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DigitalSceneManager : MonoBehaviour
{
    [SerializeField] private UnityEvent onGameStart;
    [SerializeField] private UnityEvent onGameOverSuccess;
    [SerializeField] private UnityEvent onGameOverFailed;
    public int Objectives = 3;
    private int currentObjectives = 0;
    // Start is called before the first frame update
    private void Start()
    {
        onGameStart?.Invoke();
    }
    public void checkGameOver()
    {
        currentObjectives++;
        if (currentObjectives < Objectives) return;
        onGameOverSuccess?.Invoke();
    }

    public void onGameFailed()
    {
        onGameOverFailed?.Invoke();
    }
}

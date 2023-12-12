using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class FadeOut : MonoBehaviour
{
    public Image image;
    public float fadeSpeed = 15.0f;
    [SerializeField] private UnityEvent onFadeStart;
    [SerializeField] private UnityEvent onFadeEnd;

    public void Begin()
    {
        //image.SetActive(true);
        onFadeStart?.Invoke();
        StartCoroutine(FadeCoroutine());
    }

    IEnumerator FadeCoroutine()
    {
        float fadeCount = 0;
        while(fadeCount < 1.0f)
        {
            fadeCount += fadeSpeed*Time.deltaTime;
            yield return new WaitForSeconds(0.01f);
            image.color = new Color(0, 0, 0, fadeCount);
        }
        onFadeEnd?.Invoke();
    }
}

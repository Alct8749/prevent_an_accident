using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class FadeIn : MonoBehaviour
{
    public Image image;
    [SerializeField] private UnityEvent onFadeStart;
    [SerializeField] private UnityEvent onFadeEnd;

    public void Start()
    {
        //image.SetActive(true);
        StartCoroutine(FadeCoroutine());
    }

    IEnumerator FadeCoroutine()
    {
        float fadeCount = 1.0f;
        yield return new WaitForSeconds(0.5f);
        while (fadeCount > 0.0f)
        {
            fadeCount -= 10f * Time.deltaTime;
            yield return new WaitForSeconds(0.01f);
            image.color = new Color(0, 0, 0, fadeCount);
        }
        onFadeEnd?.Invoke();
        Destroy(gameObject);
    }
}

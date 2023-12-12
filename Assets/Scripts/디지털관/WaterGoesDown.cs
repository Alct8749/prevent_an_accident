using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGoesDown : MonoBehaviour
{
    public float yScaleMax = 10.0f;
    public float yScaleSpeed = 3.0f;
    public void flushWater()
    {
        StartCoroutine(DecreaseHeight());
    }
    public void floodWater()
    {
        StartCoroutine(IncreaseHeight());
    }
    IEnumerator DecreaseHeight()
    {
        Vector3 scale = gameObject.transform.localScale;
        while (scale.y > 0)
        {
            scale.y -= yScaleSpeed * Time.deltaTime;
            gameObject.transform.localScale = scale;
            yield return new WaitForSeconds(0.01f);
        }
    }
    IEnumerator IncreaseHeight()
    {
        Vector3 scale = gameObject.transform.localScale;
        while (scale.y <= yScaleMax)
        {
            scale.y += yScaleSpeed * Time.deltaTime;
            gameObject.transform.localScale = scale;
            yield return new WaitForSeconds(0.01f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chemical_disposal : MonoBehaviour
{
    public Transform chemicalBin; // Inspector에서 할당하지 않습니다.

    private void Start()
    {
        // 런타임에 화학물질통 오브젝트를 찾아서 할당합니다.
        chemicalBin = GameObject.Find("화학물질통").transform; // "화학물질통"은 화학물질통 오브젝트의 이름입니다.
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ch_col_check")
        {
            // 화학물질통 오브젝트의 Y 스케일 크기를 10% 줄입니다.
            Vector3 currentScale = chemicalBin.localScale;
            currentScale.y -= 0.5f; // Y 스케일을 10% 줄입니다.
            chemicalBin.localScale = currentScale;

            // 화학물질통 오브젝트의 Y 좌표를 10% 내립니다.
            Vector3 currentPosition = chemicalBin.position;
            currentPosition.y -= currentPosition.y * 0.05f; // Y 좌표를 10% 내립니다.
            chemicalBin.position = currentPosition;

            // 해당 오브젝트를 파괴
            Destroy(gameObject);
        }
    }
}

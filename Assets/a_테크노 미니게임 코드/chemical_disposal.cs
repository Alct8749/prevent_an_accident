using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chemical_disposal : MonoBehaviour
{
    public Transform chemicalBin; // Inspector���� �Ҵ����� �ʽ��ϴ�.

    private void Start()
    {
        // ��Ÿ�ӿ� ȭ�й����� ������Ʈ�� ã�Ƽ� �Ҵ��մϴ�.
        chemicalBin = GameObject.Find("ȭ�й�����").transform; // "ȭ�й�����"�� ȭ�й����� ������Ʈ�� �̸��Դϴ�.
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ch_col_check")
        {
            // ȭ�й����� ������Ʈ�� Y ������ ũ�⸦ 10% ���Դϴ�.
            Vector3 currentScale = chemicalBin.localScale;
            currentScale.y -= 0.5f; // Y �������� 10% ���Դϴ�.
            chemicalBin.localScale = currentScale;

            // ȭ�й����� ������Ʈ�� Y ��ǥ�� 10% �����ϴ�.
            Vector3 currentPosition = chemicalBin.position;
            currentPosition.y -= currentPosition.y * 0.05f; // Y ��ǥ�� 10% �����ϴ�.
            chemicalBin.position = currentPosition;

            // �ش� ������Ʈ�� �ı�
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chemical_box : MonoBehaviour
{

    public GameObject flask;
    public GameObject Player;
    public GameObject success_text;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Vector3 playerPos = Player.transform.position;
            playerPos.y += 4.0f;
            playerPos.z += 5.0f;
            Instantiate(flask, playerPos, Quaternion.identity);
        }
    }
    void Update()
    {
        Vector3 currentScale = transform.localScale;
        if (currentScale.y < 0)
        {
            GameObject vaporObject = GameObject.Find("����");
            GameObject box1 = GameObject.Find("ȭ�й�����");
            GameObject box2 = GameObject.Find("ȭ�й��� �پ��°� üũ�� �Ƕ���");
            Vector3 successPrefabPosition = new Vector3(9.04f, 8.39f, -47.8f);
            Quaternion successPrefabRotation = Quaternion.Euler(0f, 180f, 0f); // Y ȸ���� 180���� ����
            Instantiate(success_text, successPrefabPosition, successPrefabRotation);
            Destroy(vaporObject);
            Destroy(box1);
            Destroy(box2);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chemical_move : MonoBehaviour
{
    public string playerTag = "Player"; // �÷��̾� ������Ʈ�� �±�
    private GameObject playerObject; // �÷��̾� ������Ʈ�� ������ ����

    private void Start()
    {
        // �÷��̾� ������Ʈ�� �±׷� ã�Ƽ� �Ҵ�
        playerObject = GameObject.FindWithTag(playerTag);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerObject != null)
        {
            Vector3 playerPos = playerObject.transform.position;
            playerPos.y += 4.0f;
            playerPos.z += 5.0f;
            transform.position = playerPos; // �ڽ��� ��ġ�� �÷��̾��� ��ġ�� ����
        }
    }
}

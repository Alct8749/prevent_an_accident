using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chemical_move : MonoBehaviour
{
    public string playerTag = "Player"; // 플레이어 오브젝트의 태그
    private GameObject playerObject; // 플레이어 오브젝트를 저장할 변수

    private void Start()
    {
        // 플레이어 오브젝트를 태그로 찾아서 할당
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
            transform.position = playerPos; // 자신의 위치를 플레이어의 위치로 설정
        }
    }
}

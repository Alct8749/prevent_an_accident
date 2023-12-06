using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_player : MonoBehaviour
{
    // Start is called before the first frame update
    int count = 0;
    public GameObject success_text;
    void Start()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("fire_disposal"))
        {
            count += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 10)
        {
            GameObject FireBall = GameObject.Find("FireBall");
            GameObject FlameThrower = GameObject.Find("FlameThrower");
            GameObject MediumFlames = GameObject.Find("MediumFlames");
            GameObject MediumFlames1 = GameObject.Find("MediumFlames (1)");
            GameObject MediumFlames2 = GameObject.Find("MediumFlames (2)");
            GameObject MediumFlames3 = GameObject.Find("MediumFlames (3)");
            Destroy(FireBall);
            Destroy(FlameThrower);
            Destroy(MediumFlames);
            Destroy(MediumFlames1);
            Destroy(MediumFlames2);
            Destroy(MediumFlames3);
            Vector3 successPrefabPosition = new Vector3(-10f, 0f, 32.8f);
            Quaternion successPrefabRotation = Quaternion.Euler(0f, 0f, 0f); // Y 회전을 180도로 설정
            Instantiate(success_text, successPrefabPosition, successPrefabRotation);
        }
    }
}

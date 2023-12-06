using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_disposal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // 해당 오브젝트를 파괴
            Destroy(gameObject);
        }
    }
}

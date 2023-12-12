using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalChecker : MonoBehaviour
{
    // Start is called before the first frame update

    void Update()
    {

           if (!GameManager.instance.isEnterCheck) { Destroy(gameObject); }
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.transform.position = GameManager.instance.lastEnteredPortal;
           GameManager.instance.isEnterCheck = false;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RememberPortal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject teleportPosition;
    public void rememberPosition()
    {
        Vector3 pos = teleportPosition.transform.position;
        GameManager.instance.lastEnteredPortal = pos;
    }
}

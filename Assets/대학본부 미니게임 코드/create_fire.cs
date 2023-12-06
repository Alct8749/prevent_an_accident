using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class create_fire : MonoBehaviour
{
    public GameObject fire;
    public GameObject fire2;
    public GameObject fire3;
    // Start is called before the first frame update
    public void burn()
    {
        Vector3 PrefabPosition = new Vector3(-0.54f, -6f, 19f);
        Vector3 PrefabPosition2 = new Vector3(19f, -6f, 30f);
        Vector3 PrefabPosition3 = new Vector3(-29f, -6f, 25f);
        Quaternion PrefabRotation = Quaternion.Euler(0f, 0f, 0f);
        Quaternion PrefabRotation2 = Quaternion.Euler(0f, 0f, 0f);
        Quaternion PrefabRotation3 = Quaternion.Euler(0f, 0f, 0f);
        Instantiate(fire, PrefabPosition, PrefabRotation);
        Instantiate(fire2, PrefabPosition2, PrefabRotation2);
        Instantiate(fire3, PrefabPosition3, PrefabRotation3);
    }
}

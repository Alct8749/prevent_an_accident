using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_explosion : MonoBehaviour
{
    public GameObject explosion;
    public GameObject explosion_bgm;
    // Start is called before the first frame update
    public void explode()
    {
        Vector3 successPrefabPosition = new Vector3(-0.7f, -3.81f, -38.4f);
        Quaternion successPrefabRotation = Quaternion.Euler(0f, 0f, 0f); 
        Instantiate(explosion, successPrefabPosition, successPrefabRotation);
        Instantiate(explosion_bgm);
    }
}

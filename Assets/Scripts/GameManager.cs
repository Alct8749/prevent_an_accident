using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public bool isItemOnHand = false;
    public bool isTechnoComplete = false;
    public bool isDigitalComplete = false;
    public bool isHeadQuaterComplete = false;
    public bool isEnterCheck = false;
    public Vector3 lastEnteredPortal;
    // Start is called before the first frame update

    void Start()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

}

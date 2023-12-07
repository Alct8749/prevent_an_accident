using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckWindowBlocking : MonoBehaviour
{
    [SerializeField] private UnityEvent onComplete;
    private int status = 0;
    public GameObject[] planes;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        foreach(GameObject o in planes)
        {
            o.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!GameManager.instance.isItemOnHand) return;
        if (status >= planes.Length) return;
        if (collision.gameObject.name == "Player")
        {
            GameManager.instance.isItemOnHand = false;
            foreach(GameObject o in GameObject.FindGameObjectsWithTag("Wood")){
                Destroy(o);
            }

            
            if (status < planes.Length)
            {
                planes[status].SetActive(true);
                status++;
                if(status == planes.Length)
                {
                    onComplete?.Invoke();
                }
            }
            
        }
    }
}

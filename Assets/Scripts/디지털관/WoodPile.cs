using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WoodPile : MonoBehaviour
{
    public GameObject player;
    public GameObject wood;
    [SerializeField] private UnityEvent onCollideEnter;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Player") return;
        if (GameManager.instance.isItemOnHand) return;
        onCollideEnter.Invoke();
        Instantiate(wood, player.transform);
        GameManager.instance.isItemOnHand = true;
    }
}

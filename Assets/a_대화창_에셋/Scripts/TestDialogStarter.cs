using UnityEngine;
using cherrydev;

public class TestDialogStarter : MonoBehaviour
{
    [SerializeField] private DialogBehaviour dialogBehaviour;
    [SerializeField] private DialogNodeGraph dialogGraph;


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ã»¼ÒºÎ")
        {
            dialogBehaviour.StartDialog(dialogGraph);
        }
    }
}
using UnityEngine;
using cherrydev;

public class Test_Dialgoue_start : MonoBehaviour
{
    [SerializeField] private DialogNodeGraph dialogGraph;
    [SerializeField] private DialogBehaviour dialogBehaviour;
    

    public void OnClick()
    {
        dialogBehaviour.StartDialog(dialogGraph);
    }
}



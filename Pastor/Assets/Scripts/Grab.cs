using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnGrab(SelectEnterEventArgs args)
    {
        args.interactableObject.transform.SetParent(args.interactorObject.transform);
    }

    // Update is called once per frame
    public void OnUnGrab(SelectExitEventArgs args)
    {
        args.interactableObject.transform.SetParent(null);
    }
}

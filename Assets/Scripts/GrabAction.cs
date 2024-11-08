using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
 
public class GrabAction : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;
 
    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.onSelectEntered.AddListener(OnGrab);
        grabInteractable.onSelectExited.AddListener(OnRelease);
    }
 
    private void OnGrab(XRBaseInteractor interactor)
    {
        Debug.Log("Objet saisi !");
    }
 
    private void OnRelease(XRBaseInteractor interactor)
    {
        Debug.Log("Objet relâché !");
    }
 
    void OnDestroy()
    {
        if (grabInteractable != null)
        {
            grabInteractable.onSelectEntered.RemoveListener(OnGrab);
            grabInteractable.onSelectExited.RemoveListener(OnRelease);
        }
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
 
public class ObjectGrab : MonoBehaviour
{
    
    private XRGrabInteractable grabInteractable;
 
    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.onSelectEntered.AddListener(OnCoinGrabbed);
    }
 
    private void OnCoinGrabbed(XRBaseInteractor interactor)
    {

        Debug.Log("object ramassées : " );
 
    }
 
    void OnDestroy()
    {
        if (grabInteractable != null)
        {
            grabInteractable.onSelectEntered.RemoveListener(OnCoinGrabbed);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
 
public class LightToggle : MonoBehaviour
{
    public Light controlledLight;
 
    private XRGrabInteractable grabInteractable;
 
    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.onSelectEntered.AddListener(ToggleLight);
    }
 
    private void ToggleLight(XRBaseInteractor interactor)
    {
        if (controlledLight != null)
        {
            controlledLight.enabled = !controlledLight.enabled;
        }
    }
 
    void OnDestroy()
    {
        if (grabInteractable != null)
        {
            grabInteractable.onSelectEntered.RemoveListener(ToggleLight);
        }
    }
}



using System.Collections;
using System.Collections.Generic;


using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
 
public class LightToggle : MonoBehaviour
{
    public Light controlledLight; // La lumière à contrôler
 
    private XRGrabInteractable grabInteractable;
 
    void Start()
    {
        // Assigne le composant XRGrabInteractable et configure l'événement de sélection
        grabInteractable = GetComponent<XRGrabInteractable>();
 
        // Associer l'événement de sélection à la fonction ToggleLight
        grabInteractable.onSelectEntered.AddListener(ToggleLight);
    }
 
    // Fonction pour allumer ou éteindre la lumière
    private void ToggleLight(XRBaseInteractor interactor)
    {
        // Inverse l'état actuel de la lumière
        if (controlledLight != null)
        {
            controlledLight.enabled = !controlledLight.enabled;
        }
    }
 
    void OnDestroy()
    {
        // Nettoyage pour éviter les erreurs après la destruction de l'objet
        if (grabInteractable != null)
        {
            grabInteractable.onSelectEntered.RemoveListener(ToggleLight);
        }
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
 
public class GrabAction : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;
 
    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
 
        // Associer les événements de saisie et de relâchement
        grabInteractable.onSelectEntered.AddListener(OnGrab);
        grabInteractable.onSelectExited.AddListener(OnRelease);
    }
 
    private void OnGrab(XRBaseInteractor interactor)
    {
        Debug.Log("Objet saisi !");
        // Exécutez des actions supplémentaires ici, par exemple changer de couleur
    }
 
    private void OnRelease(XRBaseInteractor interactor)
    {
        Debug.Log("Objet relâché !");
        // Exécutez des actions supplémentaires ici, comme restaurer la couleur d'origine
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



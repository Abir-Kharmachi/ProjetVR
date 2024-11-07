using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
 
public class ObjectGrab : MonoBehaviour
{
    
    private XRGrabInteractable grabInteractable;
 
    void Start()
    {
        // Récupérer le composant XRGrabInteractable attaché à la pièce
        grabInteractable = GetComponent<XRGrabInteractable>();
 
        // Écouter l'événement de saisie
        grabInteractable.onSelectEntered.AddListener(OnCoinGrabbed);
    }
 
    // Fonction appelée quand la pièce est saisie
    private void OnCoinGrabbed(XRBaseInteractor interactor)
    {
        // Augmenter le compteur de pièces
        

        Debug.Log("object ramassées : " );
 
        // Supprimer la pièce de la scène
      
    }
 
    void OnDestroy()
    {
        // Nettoyer l'écouteur d'événement pour éviter des erreurs après la destruction
        if (grabInteractable != null)
        {
            grabInteractable.onSelectEntered.RemoveListener(OnCoinGrabbed);
        }
    }
}

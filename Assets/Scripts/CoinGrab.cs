using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
 
public class CoinGrab : MonoBehaviour
{
    public static int coinCount = 0;
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
        coinCount += 1;

        Debug.Log("Pièces ramassées : " + coinCount);
 
        // Supprimer la pièce de la scène
        Destroy(gameObject);
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

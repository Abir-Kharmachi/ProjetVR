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
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.onSelectEntered.AddListener(OnCoinGrabbed);
    }
 
    private void OnCoinGrabbed(XRBaseInteractor interactor)
    {
        coinCount += 1;
        Debug.Log("Pièces ramassées : " + coinCount);
        Destroy(gameObject);
    }
 
    void OnDestroy()
    {
        if (grabInteractable != null)
        {
            grabInteractable.onSelectEntered.RemoveListener(OnCoinGrabbed);
        }
    }
}

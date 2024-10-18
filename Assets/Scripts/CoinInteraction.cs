using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CoinInteraction : MonoBehaviour
{
    public static int coinCount = 0;  // Compteur global de pièces
 
    void OnTriggerEnter(Collider other)
    {
        // Vérifier si la Main Camera entre en collision avec la pièce
        if (other.CompareTag("MainCamera"))
        {
            // Incrémenter le compteur de pièces
            coinCount += 1;
 
            // Afficher le score dans la console (optionnel)
            Debug.Log("Pièces ramassées : " + coinCount);
 
            // Faire disparaître la pièce
            Destroy(gameObject);
        }
    }
}
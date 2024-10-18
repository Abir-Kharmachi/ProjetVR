using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CoinInteraction : MonoBehaviour
{
    public static int coinCount = 0;  // Compteur global de pi�ces
 
    void OnTriggerEnter(Collider other)
    {
        // V�rifier si la Main Camera entre en collision avec la pi�ce
        if (other.CompareTag("MainCamera"))
        {
            // Incr�menter le compteur de pi�ces
            coinCount += 1;
 
            // Afficher le score dans la console (optionnel)
            Debug.Log("Pi�ces ramass�es : " + coinCount);
 
            // Faire dispara�tre la pi�ce
            Destroy(gameObject);
        }
    }
}
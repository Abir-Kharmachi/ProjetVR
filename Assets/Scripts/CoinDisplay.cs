using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class CoinDisplay : MonoBehaviour
{
    public Text coinText;  // Le texte UI qui affiche le compteur
 
    void Update()
    {
        // Mettre à jour le texte UI avec le nombre de pièces collectées
        coinText.text = "Pièces : " + CoinGrab.coinCount;
    }
}


using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
 
public class CoinDisplay : MonoBehaviour
{
    public Text coinText;  // Le texte UI à mettre à jour
 

    void Start()
    {
	    if (coinText == null)
	    {
		  coinText = GameObject.Find("Text").GetComponent<Text>();
	}
}
    

    void Update()
    {
        // Mettre à jour le texte UI avec le nombre de pièces collectées
        coinText.text = "Pièces : " + CoinInteraction.coinCount;
    }
}


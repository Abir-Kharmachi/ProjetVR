using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
 
public class CoinDisplay : MonoBehaviour
{
    public Text coinText;  // Le texte UI � mettre � jour
 

    void Start()
    {
	    if (coinText == null)
	    {
		  coinText = GameObject.Find("Text").GetComponent<Text>();
	}
}
    

    void Update()
    {
        // Mettre � jour le texte UI avec le nombre de pi�ces collect�es
        coinText.text = "Pi�ces : " + CoinInteraction.coinCount;
    }
}


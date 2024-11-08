using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class CoinDisplay : MonoBehaviour
{
    public Text coinText; 
    private int MaxcoinsToCollect = 25;
 
    void Update()
    {

          if (CoinGrab.coinCount >= MaxcoinsToCollect)
        {
           coinText.text = "Bravo, vous avez réussi à collecter toutes les pièces !"; 
        }else{
            coinText.text = "Pièces : " + CoinGrab.coinCount;
    }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class CoinCounter : MonoBehaviour
{
    public Text coinText; 
    private int coinCount = 0;
    
    void Start()
    {
        UpdateCoinText();
    }

    public void AddCoin()
    {
        coinCount++;
        UpdateCoinText();

    }

    private void UpdateCoinText()
    {   
        coinText.text = "Coins: " + coinCount; 
    }
        
}
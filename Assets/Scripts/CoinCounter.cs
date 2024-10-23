using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Utilise ceci si tu utilises le composant Text
// using TMPro; // Décommente ceci si tu utilises TextMeshPro

public class CoinCounter : MonoBehaviour
{
    public Text coinText; // Remplace par TextMeshProUGUI si tu utilises TextMeshPro
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
        coinText.text = "Coins: " + coinCount; // Ajuste le texte si besoin
    }
}
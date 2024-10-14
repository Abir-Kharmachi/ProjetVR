using System.Collections;
using System.Collections.Generic;



using UnityEngine;

public class CoinInteraction : MonoBehaviour
{
    public float detectionRadius = 5f;  // Distance à laquelle la pièce réagit
    public float enlargedScale = 1.5f;  // Facteur d'agrandissement de la pièce
    public Color highlightedColor = Color.yellow;  // Couleur lumineuse à proximité
    public Light coinLight;  // Lumière associée à la pièce (facultatif)

    private Vector3 originalScale;  // Taille d'origine de la pièce
    private Renderer coinRenderer;  // Renderer de la pièce pour changer la couleur
    private Color originalColor;  // Couleur d'origine de la pièce

    void Start()
    {
        // Sauvegarder l'échelle et la couleur d'origine de la pièce
        originalScale = transform.localScale;
        coinRenderer = GetComponent<Renderer>();

        if (coinRenderer != null)
        {
            originalColor = coinRenderer.material.color;
        }

        if (coinLight != null)
        {
            coinLight.enabled = false;  // Désactiver la lumière au début
        }
    }

    void Update()
    {
        // Trouver la Main Camera pour représenter le joueur
        GameObject player = Camera.main.gameObject;

        if (player != null)
        {
            // Calculer la distance entre la caméra (joueur) et la pièce
            float distanceToPlayer = Vector3.Distance(player.transform.position, transform.position);

            if (distanceToPlayer < detectionRadius)
            {
                // Agrandir la pièce et changer la couleur
                transform.localScale = Vector3.Lerp(transform.localScale, originalScale * enlargedScale, Time.deltaTime);

                if (coinRenderer != null)
                {
                    coinRenderer.material.color = Color.Lerp(coinRenderer.material.color, highlightedColor, Time.deltaTime);
                }

                if (coinLight != null)
                {
                    coinLight.enabled = true;  // Activer la lumière
                }
            }
            else
            {
                // Rétablir la taille et la couleur d'origine
                transform.localScale = Vector3.Lerp(transform.localScale, originalScale, Time.deltaTime);

                if (coinRenderer != null)
                {
                    coinRenderer.material.color = Color.Lerp(coinRenderer.material.color, originalColor, Time.deltaTime);
                }

                if (coinLight != null)
                {
                    coinLight.enabled = false;  // Désactiver la lumière
                }
            }
        }
    }
}



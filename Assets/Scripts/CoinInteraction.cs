using System.Collections;
using System.Collections.Generic;



using UnityEngine;

public class CoinInteraction : MonoBehaviour
{
    public float detectionRadius = 5f;  // Distance � laquelle la pi�ce r�agit
    public float enlargedScale = 1.5f;  // Facteur d'agrandissement de la pi�ce
    public Color highlightedColor = Color.yellow;  // Couleur lumineuse � proximit�
    public Light coinLight;  // Lumi�re associ�e � la pi�ce (facultatif)

    private Vector3 originalScale;  // Taille d'origine de la pi�ce
    private Renderer coinRenderer;  // Renderer de la pi�ce pour changer la couleur
    private Color originalColor;  // Couleur d'origine de la pi�ce

    void Start()
    {
        // Sauvegarder l'�chelle et la couleur d'origine de la pi�ce
        originalScale = transform.localScale;
        coinRenderer = GetComponent<Renderer>();

        if (coinRenderer != null)
        {
            originalColor = coinRenderer.material.color;
        }

        if (coinLight != null)
        {
            coinLight.enabled = false;  // D�sactiver la lumi�re au d�but
        }
    }

    void Update()
    {
        // Trouver la Main Camera pour repr�senter le joueur
        GameObject player = Camera.main.gameObject;

        if (player != null)
        {
            // Calculer la distance entre la cam�ra (joueur) et la pi�ce
            float distanceToPlayer = Vector3.Distance(player.transform.position, transform.position);

            if (distanceToPlayer < detectionRadius)
            {
                // Agrandir la pi�ce et changer la couleur
                transform.localScale = Vector3.Lerp(transform.localScale, originalScale * enlargedScale, Time.deltaTime);

                if (coinRenderer != null)
                {
                    coinRenderer.material.color = Color.Lerp(coinRenderer.material.color, highlightedColor, Time.deltaTime);
                }

                if (coinLight != null)
                {
                    coinLight.enabled = true;  // Activer la lumi�re
                }
            }
            else
            {
                // R�tablir la taille et la couleur d'origine
                transform.localScale = Vector3.Lerp(transform.localScale, originalScale, Time.deltaTime);

                if (coinRenderer != null)
                {
                    coinRenderer.material.color = Color.Lerp(coinRenderer.material.color, originalColor, Time.deltaTime);
                }

                if (coinLight != null)
                {
                    coinLight.enabled = false;  // D�sactiver la lumi�re
                }
            }
        }
    }
}



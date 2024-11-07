using System.Collections;
using System.Collections.Generic;



using UnityEngine;
 
public class LightControl : MonoBehaviour
{
    public Light lanterneLight; // Associe ici la lumière de la lanterne
 
    // Méthode pour allumer la lumière
    public void TurnOnLight()
    {
        lanterneLight.enabled = true;
    }
 
    // Méthode pour éteindre la lumière
    public void TurnOffLight()
    {
        lanterneLight.enabled = false;
    }
}






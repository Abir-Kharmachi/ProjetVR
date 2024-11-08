using System.Collections;
using System.Collections.Generic;



using UnityEngine;
 
public class LightControl : MonoBehaviour
{
    public Light lanterneLight; 
 
    
    public void TurnOnLight()
    {
        lanterneLight.enabled = true;
    }
 
    
    public void TurnOffLight()
    {
        lanterneLight.enabled = false;
    }
}






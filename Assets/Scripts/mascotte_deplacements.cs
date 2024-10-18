using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class FollowPlayerSimple : MonoBehaviour
{
    public Transform MainCamera;  // Le joueur que la mascotte doit suivre
    public float speed = 2f;  // Vitesse de déplacement de la mascotte
    public float followDistance = 4f;  // Distance minimale avant que la mascotte suive le joueur
 
    void Update()
    {
        // Calculer la distance entre la mascotte et le joueur
        float distance = Vector3.Distance(transform.position, MainCamera.position);
 
        // Si la distance est plus grande que la distance de suivi minimale
        if (distance > followDistance)
        {
            // Se déplacer vers le joueur
            Vector3 direction = (MainCamera.position - transform.position).normalized;
	    transform.position += direction * speed * Time.deltaTime;            
 
            // Optionnel : faire tourner la mascotte pour qu'elle fasse face au joueur
            transform.LookAt(MainCamera);
        }
    }
}
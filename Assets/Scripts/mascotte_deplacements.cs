using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class FollowPlayerSimple : MonoBehaviour
{
    public Transform MainCamera;
    public float speed = 2f; 
    public float followDistance = 4f; 
 
    void Update()
    {
        float distance = Vector3.Distance(transform.position, MainCamera.position);
        if (distance > followDistance)
        {
            Vector3 direction = (MainCamera.position - transform.position).normalized;
	        transform.position += direction * speed * Time.deltaTime;            
            transform.LookAt(MainCamera);
        }
    }
}
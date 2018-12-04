using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;

public class Magnetic : MonoBehaviour {


    // The target we are following
    public Transform target;
    // The distance in the x-z plane to the target
    public float distance = 0.5f;
   
    // How much we 
    public float heightDamping = 2.0f;
  

    void LateUpdate()
    {
        // Early out if we don't have a target
        if (!target)
            return;

        // Calculate the current rotation angles
       
        float wantedHeight = target.position.y;
        float currentHeight = transform.position.y;

        currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);
        Vector3 vector3 = new Vector3(target.position.x + 0.1f, target.position.y, target.position.z);
        transform.position = vector3;

        // Set the height of the camera
        transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);

        // Always look at the target
        transform.LookAt(target);
    }
}

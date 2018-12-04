using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;

public class Magnetic : MonoBehaviour {

    private Transform target ;
    private float distance = 0.5f;
 
    private float heightDamping = 2.0f;

    void Start()
    {
        GameObject gameObject = GameObject.FindGameObjectWithTag("Magnet");
        target = gameObject.transform;
    }

    void LateUpdate()
    {
        if (!target)
            return;
       
        float wantedHeight = target.position.y;
        float currentHeight = transform.position.y;

        currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);
        Vector3 vector3 = new Vector3(target.position.x + 0.1f, target.position.y, target.position.z);
        transform.position = vector3;

        transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);

        transform.LookAt(target);
    }
}

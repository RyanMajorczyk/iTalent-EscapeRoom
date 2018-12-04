using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTrigger : MonoBehaviour {
    public GameObject doorToOpen;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "key")
        {
            Debug.Log("The door can be opened");
            doorToOpen.transform.Rotate(0, 90, 0);
        }
        else
        {
            Debug.Log("The door can't be opened");
        }
    }
}

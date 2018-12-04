using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Magnet : MonoBehaviour {

	private void OnCollisionEnter(Collision collision)
	{
	    if (collision.gameObject.gameObject.tag == "Magnetic")
	    {
	        collision.gameObject.AddComponent(typeof(Magnetic));
        }
	    
	}
}

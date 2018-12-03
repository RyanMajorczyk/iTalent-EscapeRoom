using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagneticField : MonoBehaviour
{
    public GameObject Magnet;
    public double Force;

	// Use this for initialization
	private void Start () {
		
	}
	
	// Update is called once per frame
	private void Update ()
	{
		GetComponent<Rigidbody>().AddForce((Magnet.transform.position - transform.position), ForceMode.Force);
	}
}

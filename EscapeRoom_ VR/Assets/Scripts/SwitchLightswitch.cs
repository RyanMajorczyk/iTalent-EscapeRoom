﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLightswitch : MonoBehaviour {

    public GameObject lightSwitch;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Switch Trigger");
        lightSwitch.SetActive(!lightSwitch.activeSelf);
    }
}

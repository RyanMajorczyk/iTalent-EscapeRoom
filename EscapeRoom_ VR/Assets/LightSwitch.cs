using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class LightSwitch : MonoBehaviour {

    public Light light1;
    public Light light2;
    public Light light3;
    public GameObject lamp1;
    public GameObject lamp2;
    public GameObject lamp3;

    public void OnButtonDown(Hand fromHand)
    {
        light1.enabled = !light1.enabled;
        light2.enabled = !light2.enabled;
        light3.enabled = !light3.enabled;
        if (!light1.enabled)
        {
            lamp1.GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");
            lamp2.GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");
            lamp3.GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");
        }
        else
        {
            lamp1.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
            lamp2.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
            lamp3.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
        }
    }
}

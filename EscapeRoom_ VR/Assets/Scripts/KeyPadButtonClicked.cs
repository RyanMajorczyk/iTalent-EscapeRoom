using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.InteractionSystem;

public class KeyPadButtonClicked : MonoBehaviour
{
    private static int lastButtonClicked;

    public GameObject button;

    public int KeyValue;

    public void OnButtonDown(Hand fromHand)
    {
        button.gameObject.transform.localScale += new Vector3(1, 1, 1);
    }

    public void OnButtonUp(Hand fromHand)
    {
       
    }
}

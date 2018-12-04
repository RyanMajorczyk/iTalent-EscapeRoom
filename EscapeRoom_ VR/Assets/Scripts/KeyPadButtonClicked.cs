using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.InteractionSystem;

public class KeyPadButtonClicked : MonoBehaviour
{
    public GameObject KeyPadButton;
    public int KeyValue;
    public GameObject KeyPadScreen;
    private static string _codeTyped;
    private readonly string _rightCodeCabinet1 = "1349";
    private readonly string _rightCodeCabinet2 = "3679";
    private static Boolean _cabinet1IsOpened = false;

    public void OnButtonDown(Hand fromHand)
    {
        switch (KeyValue)
        {
            case -1:
                _codeTyped = string.Empty;
                break;
            case -2:
                CheckIfCodeIsCorrect();
                break;
            default:
                if(_codeTyped.Length <= 4)
                {
                    _codeTyped += KeyValue;
                }
                break;
        }
        GameObject.Find("KeyPad_1").GetComponent<AudioSource>().Play();
        UpdateKeyPadScreen();
        Debug.Log("Keyvalue: " + KeyValue);
    }

    public void OnButtonUp(Hand fromHand)
    {
       
    }

    private void UpdateKeyPadScreen()
    {
        Debug.Log("Screen updating: " + _codeTyped);
        var textMesh = KeyPadScreen.GetComponent<TextMesh>();
        textMesh.text = _codeTyped;
    }

    private void CheckIfCodeIsCorrect()
    {
        Debug.Log("Opening cabinet");
        if (_rightCodeCabinet1.Equals(_codeTyped))
        {
            var cabinetDoor = GameObject.Find("cabinet_door_to_open");
            cabinetDoor.transform.Rotate(-130, 0, 0);
            cabinetDoor.transform.position += new Vector3(0, 0.4f, -0.175f);
            _cabinet1IsOpened = true;
        }
        else if (_cabinet1IsOpened && _rightCodeCabinet2.Equals(_codeTyped))
        {
            var cabinetDoor = GameObject.Find("cabinet_door_to_open_2");
            cabinetDoor.transform.Rotate(-130, 0, 0);
            cabinetDoor.transform.position += new Vector3(0, 0.4f, -0.175f);
        }
        else
        {
            _codeTyped = string.Empty;
            UpdateKeyPadScreen();
        }

    }
}

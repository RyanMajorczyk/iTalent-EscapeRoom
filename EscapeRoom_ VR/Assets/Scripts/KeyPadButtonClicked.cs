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
    private readonly string _rightCode = "3940";

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
                _codeTyped += KeyValue;
                break;
        }
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
        if (_rightCode.Equals(_codeTyped))
        {
            var cabinetDoor = GameObject.Find("cabinet_door_to_open");
            cabinetDoor.transform.Rotate(0, 90, 0);
        }
        else
        {
            _codeTyped = string.Empty;
            UpdateKeyPadScreen();
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem.Sample
{
    public class PhoneKeyClick : MonoBehaviour
    {
        public string value;

        private static string insertedPhoneNumber = "";

        //private string correctPhoneNumber = "0474265348";
        private string correctPhoneNumber = "11";

        public GameObject _smartphone;

        //private GUITexture _guiTexture;

        private Renderer _renderer;

        public Material _blackScreen;
        public Material _callScreen;

        void Start()
        {
           // _guiTexture = _smartphone.GetComponent<GUITexture>();
            _renderer = _smartphone.GetComponent<Renderer>();
            _renderer.material = _blackScreen;
        }

        public void OnButtonDown(Hand fromHand)
        {
            if (insertedPhoneNumber.Length < 10)
            {
                if (value.Equals("-1"))
                {
                    if (insertedPhoneNumber.Equals(correctPhoneNumber))
                    {
                        //Make phone call
                        //_guiTexture.texture.ma
                        _renderer.material = _callScreen;
                    }

                }
                else if (value.Equals("-2"))
                {
                    insertedPhoneNumber = "";
                    Debug.Log("Cancel button Number is: " + insertedPhoneNumber);
                }
                else
                {
                    insertedPhoneNumber += value;
                    Debug.Log(insertedPhoneNumber);
                }
                Debug.Log("Button pressed " + value);
            }
            
        }
    }
}

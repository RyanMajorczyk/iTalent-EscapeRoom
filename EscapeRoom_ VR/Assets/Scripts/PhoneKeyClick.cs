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

        private Renderer _renderer;
        private AudioSource _ringtone;

        public Material _blackScreen;
        public Material _callScreen;

        void Start()
        {
            _renderer = _smartphone.GetComponent<Renderer>();
            _ringtone = _smartphone.GetComponent<AudioSource>();
            Material material = _renderer.materials[1];
            Color finalValue = Color.black;
            //Color finalValue = Color.black * 0.1f;
            material.SetColor("_EmissionColor", finalValue);
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
                        Material material = _renderer.materials[1];
                        Color finalValue = Color.white;
                        //Color finalValue = Color.white * 0.1f;
                        material.SetColor("_EmissionColor", finalValue);
                        _ringtone.mute = false;
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

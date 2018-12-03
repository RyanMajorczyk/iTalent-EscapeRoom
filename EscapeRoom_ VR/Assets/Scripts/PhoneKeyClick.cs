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
        private Color _finalValue;
        private Material _material;

        public Material _blackScreen;
        public Material _callScreen;

        void Start()
        {
            _renderer = _smartphone.GetComponent<Renderer>();
            _ringtone = _smartphone.GetComponent<AudioSource>();
            _material = _renderer.materials[1];
            _finalValue = Color.black;
            //_finalValue = Color.black * 0.1f;
            _material.SetColor("_EmissionColor", _finalValue);
        }

        void Update()
        {
            if (!_ringtone.isPlaying)
            {
                _material.SetColor("_EmissionColor", _finalValue);
            }
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
                        //_material = _renderer.materials[1];
                        _finalValue = Color.white * 2.0f;
                        //_finalValue = Color.white * 0.1f;
                        _material.SetColor("_EmissionColor", _finalValue);
                        _ringtone.Play();
                        _finalValue = Color.black;
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

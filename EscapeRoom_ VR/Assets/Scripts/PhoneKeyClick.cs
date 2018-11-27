using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem.Sample
{
    public class PhoneKeyClick : MonoBehaviour
    {
        public string value;

        private static string insertedPhoneNumber = "";

        public string correctPhoneNumber = "0474265348";

        public void OnButtonDown(Hand fromHand)
        {
            if (insertedPhoneNumber.Length < 10)
            {
                if (value.Equals("-1"))
                {
                    if (insertedPhoneNumber.Equals(correctPhoneNumber))
                    {
                        //Make phone call
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

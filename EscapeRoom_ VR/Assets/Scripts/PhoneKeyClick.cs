using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem.Sample
{
    public class PhoneKeyClick : MonoBehaviour
    {
        public string value;

        public static string insertedPhoneNumber = "";

        public void OnButtonDown(Hand fromHand)
        {
            if (value.Equals("-1"))
            {
                //Check if number is correct and call cellphone
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

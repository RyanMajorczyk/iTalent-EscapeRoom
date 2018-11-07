using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem.Sample
{
    public class PhoneKeyClick : MonoBehaviour
    {
        public string value;

        public void OnButtonDown(Hand fromHand)
        {
            Debug.Log("Button pressed " + value);
        }
    }
}

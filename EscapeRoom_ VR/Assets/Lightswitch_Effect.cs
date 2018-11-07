using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Valve.VR.InteractionSystem.Sample
{
    public class Lightswitch_Effect : MonoBehaviour
    {

        public Light light1;
        public Light light2;
        public Light light3;
        public GameObject lamp1;
        public GameObject lamp2;
        public GameObject lamp3;
        public GameObject phoneNumber;

        public void OnButtonDown(Hand fromHand)
        {
            if (light1 != null)
            {
                light1.enabled = !light1.enabled;
                light2.enabled = !light2.enabled;
                light3.enabled = !light3.enabled;
                if (!light1.enabled)
                {
                    lamp1.GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");
                    lamp2.GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");
                    lamp3.GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");
                    phoneNumber.SetActive(true);
                }
                else
                {
                    lamp1.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
                    lamp2.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
                    lamp3.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
                    phoneNumber.SetActive(false);
                }
            }


            ColorSelf(Color.cyan);
            fromHand.TriggerHapticPulse(1000);
        }

        public void OnButtonUp(Hand fromHand)
        {
            ColorSelf(Color.white);
        }

        private void ColorSelf(Color newColor)
        {
            Renderer[] renderers = this.GetComponentsInChildren<Renderer>();
            for (int rendererIndex = 0; rendererIndex < renderers.Length; rendererIndex++)
            {
                renderers[rendererIndex].material.color = newColor;
            }
        }
    }

}


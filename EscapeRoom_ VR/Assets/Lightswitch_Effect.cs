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
        public GameObject reflectionProbes;
        public GameObject lamp1;
        public GameObject lamp2;
        public GameObject lamp3;
        public GameObject phoneNumber;

        private Color originalColor;

        public void OnButtonDown(Hand fromHand)
        {
            if (light1 != null)
            {
                //light1.enabled = !light1.enabled;
                light2.enabled = !light2.enabled;
                light3.enabled = !light3.enabled;
                if (!light2.enabled)
                {
                    light1.color = new Color32(95, 75, 139, 255);
                    lamp2.GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");
                    lamp3.GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");
                    originalColor = lamp3.GetComponent<MeshRenderer>().material.GetColor("_EmissionColor");
                    lamp1.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", new Color32(95, 75, 139, 255));
                    phoneNumber.SetActive(true);
                    reflectionProbes.SetActive(false);
                }
                else
                {
                    light1.color = new Color32(229, 250, 255, 255);
                    lamp2.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
                    lamp3.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
                    lamp1.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", originalColor);
                    phoneNumber.SetActive(false);
                    reflectionProbes.SetActive(true);
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


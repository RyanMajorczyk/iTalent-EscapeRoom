//======= Copyright (c) Valve Corporation, All rights reserved. ===============

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


namespace Valve.VR.InteractionSystem.Sample
{
    public class ButtonEffect : MonoBehaviour
    {
        public Light light1;
        public Light light2;
        public Light light3;
        public GameObject lamp1;
        public GameObject lamp2;
        public GameObject lamp3;

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
                }
                else
                {
                    lamp1.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
                    lamp2.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
                    lamp3.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
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
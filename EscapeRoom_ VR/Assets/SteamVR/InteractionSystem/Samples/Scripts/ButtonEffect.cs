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
        public Light light4;
        public Material material;

        public void OnButtonDown(Hand fromHand)
        {
            light1.enabled = !light1.enabled;
            light2.enabled = !light2.enabled;
            light3.enabled = !light3.enabled;
            light4.enabled = !light4.enabled;
            if (!light1.enabled)
            {
                material.color = Color.gray;
            }
            else
            {
                material.color = Color.white;
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
using UnityEngine;
using MelonLoader;
using LoliCheat.Other;
using LoliCheat.ModSystem;
using System.Collections.Generic;

namespace LoliCheat.Mods
{
    public class Lighter : VMod
    {
        public override string ModName => "Lighter";
        private static List<GameObject> gameObjects = new List<GameObject>();
        private static bool isUsed = false;

        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                if (!isUsed)
                {
                    gameObjects.Add(GlobalUtils.GetLoli());
                    gameObjects.Add(GlobalUtils.GetHorse());
                    gameObjects.Add(GlobalUtils.GetPlayer());

                    foreach (GameObject gameObject in gameObjects)
                    {
                        Light localLight = gameObject.AddComponent<Light>();
                        localLight.type = LightType.Point;
                        localLight.shadows = LightShadows.None;
                        localLight.enabled = true;
                        localLight.color = Color.white;
                        localLight.intensity = 1.5f;
                        localLight.range = 10f;
                        localLight.transform.position += new Vector3(0f, 0f, 1f);
                    }
                    isUsed = true;
                }
                else
                    MelonLogger.LogError("Already Used!");
            }

            if (Input.GetKeyDown(KeyCode.L))
            {
                foreach (GameObject gameObject in gameObjects)
                    gameObject.GetComponent<Light>().enabled = !gameObject.GetComponent<Light>().enabled;
            }
        }
    }
}

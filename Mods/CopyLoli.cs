using UnityEngine;
using MelonLoader;
using LoliCheat.Other;
using LoliCheat.ModSystem;
using System.Collections.Generic;

namespace LoliCheat.Mods
{
    public class CopyLoli : VMod
    {
        public override string ModName => "Copy Loli";
        private static List<GameObject> Lolis = new List<GameObject>();

        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.F10))
            {
                GameObject loli = GlobalUtils.GetLoli();
                GameObject newLoli = GameObject.Instantiate(loli);
                Lolis.Add(newLoli);
                MelonLogger.Log("Added one loli");
            }

            if (Input.GetKeyDown(KeyCode.F9))
            {
                foreach (GameObject loli in Lolis)
                    GameObject.Destroy(loli);
                Lolis.Clear();
                MelonLogger.Log("Removed lolis");
            }
        }
    }
}

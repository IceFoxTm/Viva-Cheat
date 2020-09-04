using System;
using MelonLoader;
using LoliCheat.ModSystem;
using System.Collections.Generic;
using LoliCheat.Mods;

namespace LoliCheat
{
    public class Main : MelonMod
    {
        public static List<VMod> Mods = new List<VMod>();

        public override void OnApplicationStart()
        {
            MelonConsole.SetTitle("Loli Cheat BY PureFox");

            Mods.Add(new Fly());
            Mods.Add(new LoliTP());
            Mods.Add(new Lighter());
            Mods.Add(new HorseTP());
            Mods.Add(new CopyLoli());
            Mods.Add(new RayTeleport());
            Mods.Add(new HomeTeleport());
            //Mods.Add(new Experemental());

            foreach (VMod Mod in Mods)
            {
                Mod.OnStart();
                MelonLogger.Log($"|{Mod.ModName}| loaded");
            }
            MelonLogger.Log($"Loaded {Mods.Count} mods\n");
        }

        public override void OnUpdate()
        {
            foreach (VMod Mod in Mods)
                Mod.OnUpdate();
        }

        public override void OnFixedUpdate()
        {
            foreach (VMod Mod in Mods)
                Mod.OnFixedUpdate();
        }

        public override void OnLateUpdate()
        {
            foreach (VMod Mod in Mods)
                Mod.OnLateUpdate();
        }

        public override void OnGUI()
        {
            foreach (VMod Mod in Mods)
                Mod.OnGUI();
        }

        public override void OnApplicationQuit()
        {
            foreach (VMod Mod in Mods)
                Mod.OnQuit();
        }
    }
}

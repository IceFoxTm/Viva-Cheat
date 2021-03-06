﻿using MelonLoader;
using UnityEngine;
using LoliCheat.Other;
using LoliCheat.ModSystem;

namespace LoliCheat.Mods
{
    public class RayTeleport : VMod
    {
        public override string ModName => "Ray Teleport";

        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                GameObject player = GlobalUtils.GetPlayer();
                GlobalUtils.RayTeleport();
                MelonLogger.Log($"Player Teleported To: {player.transform.position}");
            }
        }
    }
}

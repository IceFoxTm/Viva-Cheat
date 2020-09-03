using MelonLoader;
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

            if (Input.GetKeyDown(KeyCode.H))
            {
                GameObject player = GlobalUtils.GetPlayer();
                player.transform.position = new Vector3(164.0f, 102.0f, 59.0f);
                MelonLogger.Log($"Player Teleported To: {player.transform.position}");
            }
        }
    }
}

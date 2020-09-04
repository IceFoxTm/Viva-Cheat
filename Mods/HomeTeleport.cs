using MelonLoader;
using UnityEngine;
using LoliCheat.Other;
using LoliCheat.ModSystem;

namespace LoliCheat.Mods
{
    public class HomeTeleport : VMod
    {
        public override string ModName => "Home Teleport";
        public override void OnUpdate()
        {

            if (Input.GetKeyDown(KeyCode.H))
            {
                GameObject player = GlobalUtils.GetPlayer();
                player.transform.position = new Vector3(164.0f, 102.0f, 59.0f);
                MelonLogger.Log($"Player Teleported To: {player.transform.position}");
            }
        }
    }
}

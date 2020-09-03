using UnityEngine;
using MelonLoader;
using LoliCheat.Other;
using LoliCheat.ModSystem;

namespace LoliCheat.Mods
{
    public class HorseTP : VMod
    {
        public override string ModName => "Horse TP";

        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                Camera playerCamera = GlobalUtils.GetPlayerCamera();
                GameObject horse = GlobalUtils.GetHorse();

                Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
                RaycastHit[] hits = Physics.RaycastAll(ray);
                if (hits.Length > 0)
                {
                    RaycastHit raycastHit = hits[0];
                    horse.transform.position = raycastHit.point;
                }

                MelonLogger.Log($"Horse Teleported To: {horse.transform.position}");
            }
        }
    }
}

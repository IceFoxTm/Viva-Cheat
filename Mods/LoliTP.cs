using UnityEngine;
using MelonLoader;
using LoliCheat.Other;
using LoliCheat.ModSystem;

namespace LoliCheat.Mods
{
    public class LoliTP : VMod
    {
        public override string ModName => "Loli TP";

        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                Camera playerCamera = GlobalUtils.GetPlayerCamera();
                GameObject loli = GlobalUtils.GetLoli();

                Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
                RaycastHit[] hits = Physics.RaycastAll(ray);
                if (hits.Length > 0)
                {
                    RaycastHit raycastHit = hits[0];
                    loli.transform.position = raycastHit.point;
                }

                MelonLogger.Log($"Loli Teleported To: {loli.transform.position}");
            }
        }
    }
}

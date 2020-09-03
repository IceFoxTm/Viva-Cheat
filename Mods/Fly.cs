using UnityEngine;
using MelonLoader;
using LoliCheat.ModSystem;
using LoliCheat.Other;

namespace LoliCheat.Mods
{
    public class Fly : VMod
    {
        public override string ModName => "Fly";

        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.V))
            {
                GlobalUtils.Fly = !GlobalUtils.Fly;
                if (GlobalUtils.Fly)
                {
                    Physics.gravity = GlobalUtils.Fly ? Vector3.zero : GlobalUtils.Grav;
                    MelonLogger.Log("Fly has been Enabled");
                }
                else
                {
                    Physics.gravity = GlobalUtils.Fly ? Vector3.zero : GlobalUtils.Grav;
                    MelonLogger.Log("Fly has been Disabled");
                }
            }

            if (Input.GetKeyDown(KeyCode.LeftShift))
                GlobalUtils.flySpeed *= 2;
            if (Input.GetKeyUp(KeyCode.LeftShift))
                GlobalUtils.flySpeed /= 2;

            if (Input.GetKeyDown(KeyCode.X))
                GlobalUtils.flySpeed = 2;

            if (GlobalUtils.flySpeed <= 0)
            {
                GlobalUtils.flySpeed = 2;
            }

            if (GlobalUtils.Fly)
            {
                GameObject player = GlobalUtils.GetPlayer();
                GameObject playercamera = GlobalUtils.GetPlayerCamera().gameObject;

                if (Input.mouseScrollDelta.y != 0)
                {
                    GlobalUtils.flySpeed += (int)Input.mouseScrollDelta.y;
                    MelonLogger.Log($"Speed: {GlobalUtils.flySpeed}");
                }

                if (Input.GetKey(KeyCode.W))
                    player.transform.position += playercamera.transform.forward * GlobalUtils.flySpeed * Time.deltaTime;
                if (Input.GetKey(KeyCode.A))
                    player.transform.position -= playercamera.transform.right * GlobalUtils.flySpeed * Time.deltaTime;
                if (Input.GetKey(KeyCode.S))
                    player.transform.position -= playercamera.transform.forward * GlobalUtils.flySpeed * Time.deltaTime;
                if (Input.GetKey(KeyCode.D))
                    player.transform.position += playercamera.transform.right * GlobalUtils.flySpeed * Time.deltaTime;

                if (Input.GetKey(KeyCode.E))
                    player.transform.position += playercamera.transform.up * GlobalUtils.flySpeed * Time.deltaTime;
                if (Input.GetKey(KeyCode.Q))
                    player.transform.position -= playercamera.transform.up * GlobalUtils.flySpeed * Time.deltaTime;

                if (System.Math.Abs(Input.GetAxis("Joy1 Axis 2")) > 0f)
                    player.transform.position += playercamera.transform.forward * GlobalUtils.flySpeed * Time.deltaTime * (Input.GetAxis("Joy1 Axis 2") * -1f);
                if (System.Math.Abs(Input.GetAxis("Joy1 Axis 1")) > 0f)
                    player.transform.position += playercamera.transform.right * GlobalUtils.flySpeed * Time.deltaTime * Input.GetAxis("Joy1 Axis 1");
            }
        }
    }
}

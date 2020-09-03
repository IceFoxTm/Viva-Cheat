using System;
using MelonLoader;
using UnityEngine;
using LoliCheat.Other;
using LoliCheat.ModSystem;

namespace LoliCheat.Mods
{
    public class Experemental : VMod
    {
        public override string ModName => "Experemental";

        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Keypad5))
                foreach (GameObject gameObject in GlobalUtils.GetAllGameObjects())
                    MelonLogger.Log($"|{gameObject.name}| {gameObject.transform.position}");


            if (Input.GetKeyDown(KeyCode.Keypad8))
                try
                {
                    Rigidbody CC = GlobalUtils.GetPlayer().GetComponent<Rigidbody>();
                    MelonLogger.Log(CC.velocity);
                }
                catch (Exception EX)
                {
                    MelonLogger.LogError(EX.ToString());
                    throw;
                }

            if (Input.GetKeyDown(KeyCode.Keypad2))
                try
                {
                    GameObject player = GlobalUtils.GetPlayer();
                    MelonLogger.Log(player.transform.position);
                }
                catch (Exception EX)
                {
                    MelonLogger.LogError(EX.ToString());
                    throw;
                }

            if (Input.GetKeyDown(KeyCode.Keypad9))
                try
                {
                    GameObject loli = GlobalUtils.GetLoli();
                    MelonLogger.Log(loli.transform.position);
                }
                catch (Exception EX)
                {
                    MelonLogger.LogError(EX.ToString());
                    throw;
                }
        }
    }
}

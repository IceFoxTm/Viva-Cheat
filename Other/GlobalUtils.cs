using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LoliCheat.Other
{
    public class GlobalUtils
    {
        public static Vector3 Grav = Physics.gravity;
        public static bool Fly = false;
        public static int flySpeed = 2;

        public static GameObject[] GetAllGameObjects()
        {
            return SceneManager.GetActiveScene().GetRootGameObjects();
        }

        public static GameObject GetPlayer()
        {
            GameObject player = new GameObject();

            foreach (GameObject gameObject in GetAllGameObjects())
                if (gameObject.name == "PLAYER")
                    player = gameObject;

            return player;
        }

        public static GameObject GetLoli()
        {
            GameObject loli = new GameObject();

            foreach (GameObject gameObject in GetAllGameObjects())
                if (gameObject.name == "ooka")
                    loli = gameObject;

            return loli;
        }

        public static GameObject GetHorse()
        {
            GameObject horse = new GameObject();

            foreach (GameObject gameObject in GetAllGameObjects())
                if (gameObject.name == "HORSE")
                    horse = gameObject;

            return horse;
        }

        public static Camera GetPlayerCamera()
        {
            Camera returnCamera = new Camera();

            foreach (Camera camera in Camera.allCameras)
                if (camera.name == "head")
                    returnCamera = camera;

            return returnCamera;
        }

        public static void RayTeleport()
        {
            Ray ray = new Ray(GetPlayerCamera().transform.position, GetPlayerCamera().transform.forward);
            RaycastHit[] hits = Physics.RaycastAll(ray);
            if (hits.Length > 0)
            {
                RaycastHit raycastHit = hits[0];
                GetPlayer().transform.position = raycastHit.point;
            }
        }
    }
}

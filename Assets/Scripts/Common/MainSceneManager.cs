using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class MainSceneManager : MonoBehaviour
{
    void Start()
    {
        ResetCameras();
        //SwitchTo2D();
    }

    IEnumerator SwitchTo2D()
    {
        XRSettings.LoadDeviceByName("");

        yield return null;

        // XRSettings.enabled = false;

        // Restore 2D camera settings.
        ResetCameras();
    }

    void ResetCameras()
    {
        for (int i = 0; i < Camera.allCameras.Length; i++)
        {
            Camera cam = Camera.allCameras[i];
            if (cam.enabled && cam.stereoTargetEye != StereoTargetEyeMask.None)
            {

                cam.transform.localPosition = Vector3.zero;
                //cam.fieldOfView = 80f;

                cam.transform.localRotation = Quaternion.identity;

                Debug.Log(cam.cameraType.ToString());
                cam.cameraType = CameraType.Game;
                cam.ResetAspect();
                XRSettings.gameViewRenderMode = GameViewRenderMode.None;
                XRSettings.enabled = false;
            }
        }
    }
    
}

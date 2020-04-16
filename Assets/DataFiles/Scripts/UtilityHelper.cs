using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UtilityHelper : MonoBehaviour
{
    
    //
    public static WebCamTexture backCam;

    private void Start()
    {
       
    }

    public static void InitializeCamera()
    {
        //WebCamDevice[] devices = WebCamTexture.devices;
        //backCam = new WebCamTexture(devices[0].name);
        //backCam = new WebCamTexture(devices[0].name, Screen.width, Screen.height);
        backCam = new WebCamTexture();
        
    }
    public static void PlayCamera()
    { 
        //playCam_GameObject.GetComponent<Renderer>().material.mainTexture = backCam;

        if (!backCam.isPlaying)
            backCam.Play();
    }

    //public static void CaptureCamera(WebCamTexture back_cam)
    //{
        
    //}

    public static void StopCamera()
    {
        backCam.Stop();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCam2 : MonoBehaviour
{
    //1a
    public bool isCamFrontCam = false;


    public WebCamTexture backCam;


    private float unitsTall;
    private float unitsWide;

    public GameObject playCam_GameObject;


    // Start is called before the first frame update
    void Start()
    {
        DeviceCheckerFn();
        PlayCamera1();
    }

    // Update is called once per frame
    void Update()
    {


        if (!(unitsTall == Screen.height) || !(unitsWide == Screen.width))
        {
            DeviceCheckerFn();
            PlayCamera1();
        }

    }

    private void DeviceCheckerFn()
    {
        //    if (isCamFrontCam)
        //    {
        //        WebCamDevice[] devices = WebCamTexture.devices;
        //        for (var i = 0; i < devices.Length; i++)
        //        {
        //            if (devices[i].isFrontFacing)
        //            {
        //                backCam = new WebCamTexture(devices[i].name, Screen.width, Screen.height);

        //            }
        //        }

        //    }
        //    else
        //    {
        //        WebCamDevice[] devices = WebCamTexture.devices;
        //        for (var i = 0; i < devices.Length; i++)
        //        {
        //            if (!devices[i].isFrontFacing)
        //            {
        //                backCam = new WebCamTexture(devices[i].name, Screen.width, Screen.height);
        //                print("hello");
        //            }
        //        }
        //    }


        WebCamDevice[] devices = WebCamTexture.devices;
        for (var i = 0; i < devices.Length; i++)
        {
            if (!devices[i].isFrontFacing)
            {
                backCam = new WebCamTexture(devices[i].name, Screen.width, Screen.height);
            }
        }
    }

    public void PlayCamera1()
    {
        if (backCam == null)
            backCam = new WebCamTexture();


        unitsTall = Screen.height;
        unitsWide = Screen.width;

        
        //playCam_GameObject.transform.localScale = new Vector3(unitsWide, unitsTall, 1f);
        
        playCam_GameObject.GetComponent<Renderer>().material.mainTexture = backCam;
        if (!backCam.isPlaying)
            backCam.Play();
    }
}

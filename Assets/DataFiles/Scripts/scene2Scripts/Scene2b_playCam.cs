using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene2b_playCam : MonoBehaviour
{
    
    //1a
    public bool isCamFrontCam =false; //Toggle Camera(button);//back cameras vs front camera
    public bool isToggleOccured = false;
    public Button toggleCam_Button;


    public WebCamTexture backCam;
    
    //public Texture defaultBackGround;
    //public RawImage background;


    //public AspectRatioFitter fit;

    //about quad
    private float unitsTall;
    private float unitsWide;

    public GameObject playCam_GameObject;


    // Start is called before the first frame update
    void Start()
    {
        //defaultBackGround = background.texture;
        //WebCamDevice[] devices = WebCamTexture.devices;
        //if(devices.Length == 0)
        //{
        //    print("No camera Detected");
        //    camAvailable = false;
        //    return;
        //}
        

    }

    // Update is called once per frame
    void Update()
    {
        PlayCamera1();
        ToggleDevice();
        
        if (!(unitsTall == Screen.height) || !(unitsWide == Screen.width)||isToggleOccured)
        {
            //DeviceCheckerFn();
            PlayCamera1();
            isToggleOccured = false;
        }

    }

    private void DeviceCheckerFn()
    {
        if (isCamFrontCam)
        {
            WebCamDevice[] devices = WebCamTexture.devices;
            for (var i = 0; i < devices.Length; i++)
            {
                if (devices[i].isFrontFacing)
                {
                    backCam = new WebCamTexture(devices[i].name, Screen.width, Screen.height);

                }
            }

        }
        else
        {
            WebCamDevice[] devices = WebCamTexture.devices;
            for (var i = 0; i < devices.Length; i++)
            {
                if (!devices[i].isFrontFacing)
                {
                    backCam = new WebCamTexture(devices[i].name, Screen.width, Screen.height);
                    print("hello");
                }
            }
        }
    }

    public void PlayCamera1()
    {

        if (backCam == null)
            backCam = new WebCamTexture();
       
        unitsTall = Screen.height;
        unitsWide = Screen.width;

        playCam_GameObject.GetComponent<Renderer>().material.mainTexture = backCam;
        playCam_GameObject.transform.localScale = new Vector3(unitsWide, unitsTall, 1f);
        if (!backCam.isPlaying)
            backCam.Play();
    }

    public void ToggleDevice()
    {
        Button btn = toggleCam_Button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }
    private void TaskOnClick()
    {
        if (isCamFrontCam)
        {
            isCamFrontCam = false;
        }
        else
        {
            isCamFrontCam = true;
        }
        isToggleOccured = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S2_CamPlayAndToggle : MonoBehaviour
{

    public WebCamTexture backCam;

    private bool camFlag = true;
    private float unitsTall;
    private float unitsWide;

    public GameObject playCam_GameObject;


    // Start is called before the first frame update
    void Start()
    {
        PlayCamera1();
    }

    // Update is called once per frame
    void Update()
    {


        //if (!(unitsTall == Screen.height) || !(unitsWide == Screen.width))
        //{
        //    PlayCamera1();
        //}
        PlayCamera1();
    }


    public void PlayCamera1()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        backCam = new WebCamTexture(devices[0].name, Screen.width, Screen.height);
        playCam_GameObject.GetComponent<Renderer>().material.mainTexture = backCam;

        //unitsTall = Screen.height;
        //unitsWide = Screen.width;
        //playCam_GameObject.transform.localScale = new Vector3(unitsWide, unitsTall, 1f);

        //playCam_GameObject.transform.localScale = new Vector3(1f, 1f, 1f);


        if (!backCam.isPlaying)
            backCam.Play();
    }

    public void Toggle()
    {
        print("i am in toggle");
        WebCamDevice[] devices = WebCamTexture.devices;
        
        if (!camFlag)
        {
            backCam = new WebCamTexture(devices[0].name, Screen.width, Screen.height);
            playCam_GameObject.GetComponent<Renderer>().material.mainTexture = backCam;
            camFlag = true;
            print("dev1");
        }
        else
        {
            backCam = new WebCamTexture(devices[0].name, Screen.width, Screen.height);
            playCam_GameObject.GetComponent<Renderer>().material.mainTexture = backCam;
            camFlag = false;
            print("dev2");
        }
        print("i was in toggle");
    }
}

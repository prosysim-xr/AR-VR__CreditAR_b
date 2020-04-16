using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCamera : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
        PlayCamera1();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void PlayCamera1()
    {
        if (WebCamController2.backCam == null)
            WebCamController2.backCam = new WebCamTexture();

        GetComponent<Renderer>().material.mainTexture = WebCamController2.backCam;

        if (!WebCamController2.backCam.isPlaying)
            WebCamController2.backCam.Play();
    }
}

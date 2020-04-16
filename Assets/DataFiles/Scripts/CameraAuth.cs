using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAuth : MonoBehaviour
{
    private WebCamTexture cam_texture;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("PlayCamCoRoutine");
        //PlayCamera1();
    }

    // Update is called once per frame
    void Update()
    {

    }
    //private void PlayCamera1()
    //{
    //    if (WebCamController2.backCam == null)
    //        WebCamController2.backCam = new WebCamTexture();

    //    GetComponent<Renderer>().material.mainTexture = WebCamController2.backCam;

    //    if (!WebCamController2.backCam.isPlaying)
    //        WebCamController2.backCam.Play();
    //}
    IEnumerator PlayCamCoRoutine()
    {
        yield return Application.RequestUserAuthorization(UserAuthorization.WebCam);
        if (Application.HasUserAuthorization(UserAuthorization.WebCam))
        {
            Debug.Log("webcam found");
            StartWebCam();
        }
        else
        {
            Debug.Log("webcam not found");
        }

    }

    void StartWebCam()
    {
        WebCamDevice device = WebCamTexture.devices[0];

        cam_texture = new WebCamTexture(device.name);
        GetComponent<Renderer>().material.mainTexture = cam_texture;
        cam_texture.Play();
    }
}

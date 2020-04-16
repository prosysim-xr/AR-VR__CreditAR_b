
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3b_playCamera : MonoBehaviour
{
    public WebCamTexture backCam;

    //about quad
    private float unitsTall;
    private float unitsWide;

    public GameObject quad;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!(unitsTall == Screen.height) || !(unitsWide == Screen.width))
        {
            PlayCamera1();
        }

    }
    public void SetSpriteTexture()
    {
        //Renderer rend = GameObject.FindGameObjectWithTag("web").GetComponent<Renderer>();
        //rend.material.mainTexture = backCam;

    }

    private void PlayCamera1()
    {

        if (backCam == null)
            backCam = new WebCamTexture();
        ////
        //unitsTall = Camera.main.orthographicSize * 2f;
        //unitsWide = Camera.main.orthographicSize * 2f * (float)Screen.width / (float)Screen.height;
        //quad.transform.localScale = new Vector3(unitsWide, unitsTall, 1f);
        ////
        unitsTall = Screen.height;
        unitsWide = Screen.width;


        //GetComponent<Renderer>().material.mainTexture = backCam;
        //Renderer rend = GameObject.FindGameObjectWithTag("web").GetComponent<Renderer>();
        //rend.material.mainTexture = backCam;
        quad.GetComponent<Renderer>().material.mainTexture = backCam;
        quad.transform.localScale = new Vector3(unitsWide, unitsTall, 1f);
        if (!backCam.isPlaying)
            backCam.Play();
    }
}

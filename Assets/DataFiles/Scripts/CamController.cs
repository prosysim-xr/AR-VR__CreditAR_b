//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class CamController : MonoBehaviour
//{
//    //cameras variables
//    public bool isCamAvailable;
//    public  WebCamTexture backCamr;
//    public  WebCamTexture frontCamr;
//    public Texture defaultBackGround;
//    public AspectRatioFitter fit;

//    //
//    public Sprite background;
//    public RawImage rawImage;

//    //
//    public RawImage background;
//    public AspectRatioFitter fit;

//    //access shader, texture, and color



//    private void Awake()
//    {
        
//        //rawImage = gameObject.GetComponent<RawImage>().material.SetTexture(asdf,backCamr);
//        //defaultBackGround = GetComponent<Renderer>().material.mainTexture;
//    }

//    //public void SetSpriteTexture()
//    //{
//    //    Renderer rend = GameObject.FindGameObjectWithTag("webCam_sprite").GetComponent<Renderer>();
//    //    rend.material.mainTexture = backCamr;
//    //}

//    // Start is called before the first frame update
//    void Start()
//    {
        
//        defaultBackGround.texture = background.texture;
        
//        WebCamDevice[] devices = WebCamTexture.devices;
//        if (devices.Length == 0)
//        {
//            print("no camera detected");
             
//        }
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene1_sceneManager : MonoBehaviour
{
    //public  GameObject s2_obj;

    //Scene1 buttons wrt scenemanager game object
    //public Button scan;
    //public Button exit;
    //public Button about;

    private void Start()
    {
       // s2_obj = GameObject.Find("SceneManager").GetComponent<S2_CamPlayAndToggle2>();
    }
    void Update()
    {
        //Scne1Buttons();
    }

    //Scene1 related
    //public void Scne1Buttons()
    //{
    //    Button btn = scan.GetComponent<Button>();
    //    if (btn == scan)
    //    {
    //        btn.onClick.AddListener(ScanTask);
    //    }
    //    else if (btn == exit)
    //    {
    //        btn.onClick.AddListener(ExitTask);
    //    }
    //    else if (btn == about)
    //    {
    //        btn.onClick.AddListener(KnowAboutTask);
    //    }
    //}

    public void KnowAboutTask()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(6);

    }

    public void ExitTask()
    {
        Application.Quit();
    }

    public void ScanTask()
    {
        //S2_CamPlayAndToggle2.backCam.Stop();
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

}

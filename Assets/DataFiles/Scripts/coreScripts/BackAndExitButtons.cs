using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackAndExitButtons : MonoBehaviour
{
    public int prevSceneNo;
    // Start is called before the first frame update
    void Start()
    {
        //currentSceneNo = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ExitAppfn()
    {
        Application.Quit();
    }

    public void BackButtonfn()
    {
        UtilityHelper.backCam.Stop();
        UnityEngine.SceneManagement.SceneManager.LoadScene(prevSceneNo);
       
    }

    public void ClickToScan()
    {
        UtilityHelper.backCam.Stop();
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void ClickToOfferMenu()
    {
        UtilityHelper.backCam.Stop();
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }

    public void ClickToMainMenu()
    {
        UtilityHelper.backCam.Stop();
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void ClickToMainMenu2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

}

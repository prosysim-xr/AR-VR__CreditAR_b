using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public void ClickToScene3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }

    

}

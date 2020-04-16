using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2_SceneManager : MonoBehaviour
{
    public int nextSceneBuildNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickToOfferMenuScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneBuildNum);
    }
}

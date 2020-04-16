using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppDemoScript : MonoBehaviour
{

    public int nextSceneNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnclickAppDemo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneNum);
    }
}

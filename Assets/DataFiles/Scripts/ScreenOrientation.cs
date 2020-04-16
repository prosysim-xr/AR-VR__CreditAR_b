using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenOrientation : MonoBehaviour
{
    public Text orientation_Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Screen.width < Screen.height)
        {
            orientation_Text.text = "Please put your device in landscape mode";
        }
    }
}

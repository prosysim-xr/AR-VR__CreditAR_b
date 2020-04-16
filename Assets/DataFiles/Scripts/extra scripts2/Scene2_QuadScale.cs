using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2_QuadScale : MonoBehaviour
{
    public GameObject quad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        quad.transform.localScale = new Vector3(Screen.width, Screen.height, 1);
    }
}

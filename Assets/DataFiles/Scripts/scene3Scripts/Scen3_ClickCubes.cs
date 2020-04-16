using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scen3_ClickCubes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OfferMenuClickFn();
    }

    private static void OfferMenuClickFn()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                BoxCollider bc = hit.collider as BoxCollider;
                if (bc != null)
                {
                    if (bc.tag == "graph")
                    {
                        UtilityHelper.backCam.Stop();
                        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
                    }
                    else if (bc.tag == "statement")
                    {
                        UtilityHelper.backCam.Stop();
                        UnityEngine.SceneManagement.SceneManager.LoadScene(4);
                    }
                    else if (bc.tag == "activation")
                    {
                        UtilityHelper.backCam.Stop();
                        UnityEngine.SceneManagement.SceneManager.LoadScene(5);
                    }
                    else if (bc.tag == "offer")
                    {
                        UtilityHelper.backCam.Stop();
                        UnityEngine.SceneManagement.SceneManager.LoadScene(7);
                    }

                }
            }
        }
    }
}

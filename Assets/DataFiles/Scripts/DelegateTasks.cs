using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTasks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MyCoroutine1());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MyCoroutine1()
    {
        yield return 0;
    }
}

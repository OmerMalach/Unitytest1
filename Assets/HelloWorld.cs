using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("hello world started");
        Debug.Log("im printing from debug");
        Debug.LogWarning("yo motherfucker!");
        Debug.LogError("hhahahaahah");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

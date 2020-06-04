using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartWhenStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MirrorCameraScript>().enabled = false;
        GetComponent<MirrorCameraScript>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

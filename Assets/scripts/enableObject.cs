﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enableObject : MonoBehaviour
{
    public GameObject gameObject;
    public Button closeBtn;
 
    // Start is called before the first frame update
    void Start()
    {
        gameObject = this.GetComponent<GameObject>();
      
        closeBtn.onClick.AddListener(TaskOnClick);
        
    }


    // Update is called once per frame
    private void TaskOnClick()
    {

     //   Destroy(closeBtn.gameObject);
        gameObject.SetActive(false);

    }

    public void DisplayObject()
    {

       gameObject.SetActive(true);

    }
}

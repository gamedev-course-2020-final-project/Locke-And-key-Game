using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableButton : MonoBehaviour
{
    public Button openBtn;
    // Start is called before the first frame update
    void Start()
    {
        openBtn = this.GetComponent<Button>();
        openBtn.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        
        Destroy(openBtn.gameObject);
       
    }


}

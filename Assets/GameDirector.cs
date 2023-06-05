using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{

    public Image UIobj;
    public bool roop;
    public float countTime = 100.0f;
    GameObject gauge;
   
    void Start()
    {
        this.gauge = GameObject.Find("gauge");
    }
   
    public void HPdelete()
    {
        this.gauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    void Update()
    {
        if (roop)
        {
            UIobj.fillAmount -= 1.0f / countTime * Time.deltaTime;
        }
    }
}

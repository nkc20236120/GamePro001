using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    float limit = 1.0f / 6000.0f;
    GameObject TimeGauge;
    float time = 1.0f;

    void Start()
    {
        this.TimeGauge = GameObject.Find("TimeGauge");
    }

    private void Update()
    {
        this.TimeGauge.GetComponent<Image>().fillAmount -= limit;
    }


    void DecreaseTIme()
    {
        this.TimeGauge.GetComponent<Image>().fillAmount -= 1.0f / 6000.0f;
    }
}

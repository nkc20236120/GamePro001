using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    

    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        int key = 0;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-0.2f,0,0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, -0.2f, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.2f, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0.2f, 0);
        }

    }
}
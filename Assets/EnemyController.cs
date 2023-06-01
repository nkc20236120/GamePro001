using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject Player;

    void Start()
    {
        this.Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.01f, 0, 0);

        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = Player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 0.5f;

        if (d < r1 + r2)
        {
            Destroy(gameObject);
        }
       
    }
}

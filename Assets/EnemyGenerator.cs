using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{

    public GameObject Enemy_0Pre;
    float span = 1f;
    float delta = 3;

    void Start()
    {

    }

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(Enemy_0Pre);
            int px = Random.Range(4, -5);
            go.transform.position = new Vector3(10, px, 1);
        }
    }
}
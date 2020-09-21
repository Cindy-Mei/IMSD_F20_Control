using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForth : MonoBehaviour
{
    Transform myTransform;

    float speed = 1.25f;

    void Start()
    {
        myTransform = transform;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)){
          myTransform.position += Vector3.up * speed;
        }

        if(Input.GetKeyDown(KeyCode.S)){
          myTransform.position += Vector3.down * speed;
        }
    }
}

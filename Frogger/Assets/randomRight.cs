using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomRight : MonoBehaviour
{
    Transform myTransform;
    float speed;

    void Start()
    {
        myTransform = transform;
        speed = Random.Range(10.00f, 20.00f);
    }

    void Update()
    {
        myTransform.position += Vector3.right * Time.deltaTime * speed;

        if(myTransform.position.x >= 100){
          myTransform.position += Vector3.left * 100;
        }
    }
}

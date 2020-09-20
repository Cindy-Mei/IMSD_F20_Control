using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class determinDiscontiguously : MonoBehaviour
{
    public Transform myTransform;

    private float timer;

    void Start()
    {
        myTransform.position = new Vector3(2, 0, 0);
        timer = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 1){
          myTransform.position += new Vector3(0, 0, 1);

          timer = 0;
        }
    }
}

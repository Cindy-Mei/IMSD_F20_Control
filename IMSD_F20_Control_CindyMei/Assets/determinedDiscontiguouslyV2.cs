using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class determinedDiscontiguouslyV2 : MonoBehaviour
{
    public Transform myTransform;

    public float x;
    public float y;
    public float z;

    public float speed;

    private float timer;

    void Start()
    {
        myTransform.position = new Vector3(0, 0, 0);
        timer = 0;
    }


    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 1){
          myTransform.position += new Vector3(Random.Range(-(x), x), y, z) * speed * Time.deltaTime;
        }
    }
}

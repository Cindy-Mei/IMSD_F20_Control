using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomDiscontiguouslyV2 : MonoBehaviour
{
    public Transform myTransform;

    public float rangeX;
    public float rangeY;
    public float rangeZ;

    public float speed;

    void Start()
    {
        myTransform.position = new  Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position += new Vector3(Random.Range(0, rangeX), Random.Range(0, rangeY), Random.Range(0, rangeZ)) * speed;
    }
}

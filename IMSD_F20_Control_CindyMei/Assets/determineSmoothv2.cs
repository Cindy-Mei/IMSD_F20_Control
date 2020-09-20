using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class determineSmoothV2 : MonoBehaviour
{
    public Transform myTransform;

    public float x;
    public float y;
    public float z;

    public float speed;

    void Start()
    {
        myTransform.position = new Vector3(0, 0, 0);
    }

    void Update()
    {
        myTransform.position += new Vector3(x, y, z) * speed;
    }
}

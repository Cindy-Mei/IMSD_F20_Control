using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class determineSmooth : MonoBehaviour
{
    public Transform myTransform;

    void Start()
    {
      myTransform.position = new Vector3(-4, 0, 0);
    }

    void Update()
    {
      myTransform.position += new Vector3(1, 0, 0) * Time.deltaTime;
    }
}

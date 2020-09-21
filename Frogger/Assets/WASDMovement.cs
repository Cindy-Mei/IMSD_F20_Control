using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDMovement : MonoBehaviour
{
  Transform myTransform;

  void Start()
  {
      myTransform = transform;
  }

  void Update()
  {
      if(Input.GetKey(KeyCode.W)){
        myTransform.position += Vector3.up;
      }

      if(Input.GetKey(KeyCode.S)){
        myTransform.position += Vector3.down;
      }

      if(Input.GetKey(KeyCode.D)){
        myTransform.position += Vector3.right;
      }

      if(Input.GetKey(KeyCode.A)){
        myTransform.position += Vector3.left;
      }
    }
}

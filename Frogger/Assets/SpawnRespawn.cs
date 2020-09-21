using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRespawn : MonoBehaviour
{
    public GameObject frog;

    public GameObject frogPrefab;

    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space)){
        if(frog != null){
          Destroy(frog);
        }
      }

      if(Input.GetKeyDown(KeyCode.Return)){
        if(frog == null){
          frog = Instantiate(frogPrefab, new Vector3(50, -15, 0), Quaternion.identity);
        }
      }
    }
}

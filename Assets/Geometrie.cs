using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Geometrie : MonoBehaviour {
    public float speed=1.0f;
    public GameObject cube1, cube2;
    bool V=false;
   
    void Start () {
        cube1.transform.position = new Vector3 (cube1.transform.position.x,cube1.transform.position.y,cube1.transform.position.z);
         cube2.transform.position = new Vector3 (cube2.transform.position.x,cube2.transform.position.y,cube2.transform.position.z);
    }

    
    void Update () { 
        if(cube1.activeSelf){
            cube1.transform.position = Vector3.Lerp (cube1.transform.position,cube2.transform.position,speed*Time.deltaTime);
        }
}
}

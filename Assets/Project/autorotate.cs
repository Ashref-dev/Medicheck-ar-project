using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autorotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, 90.0f*Time.deltaTime , 0);
    }
}

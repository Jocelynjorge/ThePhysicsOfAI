using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellMove : MonoBehaviour
{
    float speed = 1;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, (speed * Time.deltaTime)/2.0f, speed * Time.deltaTime);
    }
}

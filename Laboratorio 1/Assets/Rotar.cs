using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{
    int speed = 40;
    
    void Start()
    {

    }

   
    void Update()
    {
        transform.Rotate(0, Time.deltaTime * speed, 0);
    }
}

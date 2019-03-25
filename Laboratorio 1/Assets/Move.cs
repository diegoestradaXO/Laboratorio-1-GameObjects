using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    int speedRate = 15;
    
    void Start()
    {

    }


    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speedRate * Time.deltaTime,
            0, Input.GetAxis("Vertical") * speedRate * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModificarTamaño : MonoBehaviour
{
    int add = 7;
    int sub = -7;
   
    void Start()
    {

    }
    void Update()
    {
        Vector3 vector3 = new Vector3(1, 1, 1);

        if (Input.GetKey(KeyCode.G))
            transform.localScale += new Vector3(Time.deltaTime * add, Time.deltaTime * add, Time.deltaTime * add);
        else if (Input.GetKey(KeyCode.P))
            transform.localScale += new Vector3(Time.deltaTime * sub, Time.deltaTime * sub, Time.deltaTime * sub);
    }
}

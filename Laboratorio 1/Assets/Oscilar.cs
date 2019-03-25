using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilar : MonoBehaviour
{
    private float delta = 1.3f;
    private float speedRate = 1.8f;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        Vector3 vector = startPosition;
        vector.y += delta * Mathf.Sin(Time.time * speedRate);
        transform.position = vector;
    }
}

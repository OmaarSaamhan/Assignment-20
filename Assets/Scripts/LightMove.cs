using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KightMove : MonoBehaviour
{
    public float speed = 3f;
    float yMove = 1f;
    void Start()
    {

    }

    void Update()
    {
        yMove += speed;
        transform.rotation = Quaternion.Euler(transform.position.x, yMove, transform.position.z);
    }
}

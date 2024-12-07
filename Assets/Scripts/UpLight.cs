using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpLight : MonoBehaviour
{
    public float speed = 2f;
    float yRout = 1f;
    float yMove = 1;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float yMove = Mathf.Sin(Time.time) * 1.8f / 2f;
        Vector3 amoudPos = new Vector3(0.14f, 4.7625f, 0.1f);
        transform.position = new Vector3(0f, yMove, 0f) + amoudPos;
        yRout -= speed;
        transform.rotation = Quaternion.Euler(transform.position.x, yRout, transform.position.z);
    }
}

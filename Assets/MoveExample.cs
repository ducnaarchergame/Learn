using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveExample : MonoBehaviour
{
    public Transform target;
    public float speed = 150f;
    public Vector3 velocity = Vector3.zero;

    void Update()
    {
        Debug.Log("velocity: " + velocity);
        transform.position = Vector3.SmoothDamp(transform.position, target.position, ref velocity, speed * Time.deltaTime);
    }
}

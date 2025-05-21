using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_movement : MonoBehaviour
{

    public Transform target; 
    public float speed = 0.125f;
    public Vector3 offset;   

    void LateUpdate()
    {
        Vector3 position = target.position + offset;
        Vector3 newPosition = Vector3.Lerp(transform.position, position, speed);
        transform.position = newPosition;
    }


}


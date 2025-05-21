using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement2 : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    public float speed = 0.125f;
    public Vector3 offset;

    void LateUpdate()
    {
        Vector3 centerPoint = (player1.position + player2.position) / 2;
        Vector3 position = centerPoint + offset;
        Vector3 newPosition = Vector3.Lerp(transform.position, position, speed);
        transform.position = newPosition;
    }
}

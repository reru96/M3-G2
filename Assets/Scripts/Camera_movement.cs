using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 startPosition;
    public float maxDistance = 10f;
    public float speed = 2f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = rb.position;
    }

    void FixedUpdate()
    {
        Vector2 newPosition = rb.position + Vector2.right * speed * Time.fixedDeltaTime;

        if (Vector2.Distance(startPosition, newPosition) <= maxDistance)
        {
            rb.MovePosition(newPosition);
        }
        else
        {
            rb.MovePosition(startPosition); 
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveSquare_2 : MonoBehaviour
{

    [SerializeField] private GameObject oggetto;
    private Rigidbody2D rb;
    public float speed = 5f;
    private Vector2 startPosition;
    public float maxDistance = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector2 inputDirection = new Vector2(h, v).normalized;

        Vector2 newPosition = rb.position + inputDirection * (speed * Time.deltaTime);

        if (Vector2.Distance(startPosition, newPosition) < maxDistance)
        {
            rb.MovePosition(newPosition);
        }
        else
        {
            rb.MovePosition(startPosition); 
        }
    }
}





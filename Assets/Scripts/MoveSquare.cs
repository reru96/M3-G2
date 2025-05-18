using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquare : MonoBehaviour
{
    [SerializeField] private GameObject oggetto;
    private Rigidbody2D rb;
    public float speed = 5;
    private Vector3 direction = new Vector3(0,0,0);
    // Start is called before the first frame update
    void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 newDirection = new Vector3(h, v, 0);
        transform.position += newDirection * (speed * Time.deltaTime);
    }
}

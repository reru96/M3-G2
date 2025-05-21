using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;



public class Player : MonoBehaviour
{
    
    [SerializeField]public float speed = 5f;
    [SerializeField]public float jumpForce = 7f;  
    public int playerNumber;
    private Rigidbody2D rb;
    private bool isGrounded = false;
    private float moveInput;
    private string horizontalInput;
    private string jumpInput;
    private bool jumpRequest = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        horizontalInput = "P" + playerNumber + "Horizontal";
        jumpInput = "P" + playerNumber + "Jump";

    }
    void Start()
    {
        
    }

    void Update()
    {
        moveInput = Input.GetAxisRaw(horizontalInput);

        if (Input.GetButtonDown(jumpInput) && isGrounded)
        {
            jumpRequest = true; 
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        
        if (jumpRequest)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpRequest = false;
            isGrounded = false;
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}



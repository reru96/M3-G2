using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class End : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.tag == "Player1")  
        {
            Debug.Log("Player 1 vince");
        }
        else if (collision.gameObject.tag == "Player2" )
        {
            Debug.Log("Player 2 vince");
        }
    }

    


}




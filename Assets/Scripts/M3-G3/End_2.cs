using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
        {
            Debug.Log("Player 1 è ENTRATO nel prossimo livello");
        }
         
        if (other.CompareTag("Player2"))
        {
            Debug.Log("Player 2 è ENTRATO nel prossimo livello");
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
        {
            Debug.Log("Il Player 1 è USCITO dal livello e torna al livello precendente.");

        }

        if (other.CompareTag("Player2"))
        {
            Debug.Log("il Player 2 è USCITO dal livello e torna al livello precedente");
        }
    }
}

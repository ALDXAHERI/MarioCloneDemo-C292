using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        Debug.Log("Enter");
    }
    private void OnCollisionExit2D(Collision2D collision) 
    {
        Debug.Log("Exit");
    }

    private void OnCollisionStay2D(Collision2D collision) 
    {
        Debug.Log("Stay");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter"); 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit");
    }

    private void OnStriggerStay2d(Collider2D collision)
    {
        Debug.Log("Stay");
    }
    
}

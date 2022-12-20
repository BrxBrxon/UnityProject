using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }


    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.velocity = new Vector3(0, 8, 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsForPhone : MonoBehaviour
{

    public float moveSpeed;
    Rigidbody2D rb;

     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

     public void Right_mover()
    {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }

    public void Left_mover()
    {
        rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
    }
}


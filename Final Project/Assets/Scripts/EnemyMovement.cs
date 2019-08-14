using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private bool moving;

    public float moveSpeed = 0.01f;
    
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    //when the enemy has spawned, start moving the enemy left
    void OnEnable()
    {
        moving = true;
    }

    void OnDisable()
    {
        moving = false;
    }

    public void Stop()
    {
        moving = false;
    }

    void FixedUpdate()
    {
        if (moving)
        {
            rb2d.MovePosition((Vector2)transform.position + Vector2.left * moveSpeed);
        }
    }
}

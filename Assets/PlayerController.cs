using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D RB_player;
    public float speed = 20f;
    public Vector2 direction;
    
    void Start()
    {
        RB_player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
        {
            direction = Vector2.left;
        }
        else if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
        {
            direction = Vector2.right;
        }
        else
        {
            direction = Vector2.zero;

        }
        
        
        
    }

    private void FixedUpdate()
    {
        if (direction == Vector2.zero)
        {
            return;
        }
        RB_player.AddForce(direction*speed); // vektör * hız
    }
}

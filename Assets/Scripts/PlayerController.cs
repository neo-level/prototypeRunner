﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const float Speed = 20.0f;
    private const float JumpForce = 700.0f;
    private float _horizontalInput;

    public bool isOnGround = true;

    private Rigidbody _playerRigidbody;


    // Start is called before the first frame update
    private void Start()
    {
        // Gets the rigid body component from the player object.
        _playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        GetUserInput();
        UserJump();
    }

    // Retrieve the user input when pressing the arrow buttons.
    private void GetUserInput()
    {
        // Get the user input for horizontal movement.
        _horizontalInput = Input.GetAxis("Horizontal");

        // Move the user based on the Horizontal input.
        transform.Translate(translation: Vector3.right * (Time.deltaTime * Speed * _horizontalInput));
    }

    private void UserJump()
    {
        // Checks if the player presses the space bar.
        if (Input.GetKeyDown(key: KeyCode.Space) && isOnGround)
        {
            // Adds physics to the player allowing an upwards jump.
            // Immediately applies force. using the impulse mode.
            _playerRigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);

            // Sets boolean on ground to false.
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(tag: "Ground"))
        {
            isOnGround = true;
        }
    }
}
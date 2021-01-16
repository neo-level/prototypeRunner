using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed = 20.0f;
    private float _horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        GetUserInput();
    }

    // Retrieve the user input when pressing the arrow buttons.
    private void GetUserInput()
    {
        // Get the user input for horizontal movement.
        _horizontalInput = Input.GetAxis("Horizontal");

        // Move the user based on the Horizontal input.
        transform.Translate(Vector3.right * (Time.deltaTime * _speed * _horizontalInput));
    }
}
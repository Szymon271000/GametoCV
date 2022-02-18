using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private CharacterController _controller;
    private float _speed = 3.5f;
    private float _runningspeed = 7.0f;
    private float _gravity = 9.81f;
    private float _jumpHeight = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();  
    }

    void CalculateMovement()
    {
        float horizontalinput = Input.GetAxis("Horizontal");
        float verticalinput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalinput, 0, verticalinput);
        Vector3 velocity = direction * _speed;
        if (Input.GetButton("Run"))
        {
            velocity = direction * _runningspeed;
        }

        if (_controller.isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            velocity.y += _jumpHeight * 5;
        }

        velocity.y -= _gravity;
        velocity = transform.TransformDirection(velocity);
        _controller.Move(velocity * Time.deltaTime);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 30.0f;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        float verticalInput = Input.GetAxis("Vertical");

        // move the object forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);

        // tilt the object up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * verticalInput * rotationSpeed * Time.fixedDeltaTime);
    }
}

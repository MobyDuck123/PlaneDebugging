using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnyPropeller : MonoBehaviour
{
    public float rotationSpeed = 400f; 

    
    void Update()
    {
        
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}

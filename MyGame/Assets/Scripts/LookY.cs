using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour
{
    // Start is called before the first frame update
    private float _sensitivity = 3.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float _moveY = Input.GetAxis("Mouse Y");
        Vector3 newRotation = transform.localEulerAngles;
        newRotation.x -= _moveY * _sensitivity;
        transform.localEulerAngles = newRotation;
    }
}

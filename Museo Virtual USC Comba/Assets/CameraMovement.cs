using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public float moveSpeed = 0.001f;

    void Update()
    {/*
        // Obtén la entrada del joystick izquierdo
        float horizontalInput = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).x;
        float verticalInput = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).y;

        // Calcula el desplazamiento de la cámara basado en la entrada del joystick
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime;

        // Aplica el movimiento a la posición de la cámara
        transform.Translate(movement);
        */      

        
        float horizontalInput_ = Input.GetAxis("Horizontal");
        float verticalInput_ = Input.GetAxis("Vertical");

        Vector3 movement_ = new Vector3(horizontalInput_, 0, verticalInput_) * moveSpeed * Time.deltaTime;
        transform.Translate(movement_);
        
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float sensitivity;

    void FixedUpdate()
    {
        float rotateHorizontal = Input.GetAxis("Mouse X");
        float rotateVertical = Input.GetAxis("Mouse Y");

        gameObject.transform.Rotate(0, rotateHorizontal * sensitivity, 0);
        gameObject.transform.Rotate(-rotateVertical * sensitivity, 0, 0);
    }

}
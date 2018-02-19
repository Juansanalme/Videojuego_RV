using System;
using UnityEngine;
 
public class MouseLook : MonoBehaviour
{
    //public float speedH = 2.0f;
    public float speedV = 2.0f;

    //private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Update () {
        //yaw += speedH * Input.GetAxis("Mouse X");
        //pitch -= speedV * Input.GetAxis("Mouse Y");

        //transform.Rotate(pitch, yaw, 0.0f);

        pitch = -speedV * Input.GetAxis("Mouse Y");
        transform.Rotate(pitch, 0.0f, 0.0f);
    }
}
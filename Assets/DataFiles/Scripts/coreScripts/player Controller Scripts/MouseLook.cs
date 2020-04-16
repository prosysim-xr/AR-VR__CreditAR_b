using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseLook : MonoBehaviour
{
    //data variable for joystick and jump button
    public FixedJoystick fixedJoystick_look;

    //Reference to attach in the unity editor
    public Transform playerTarget;
    public Transform playerTarget2;
    public float mouseSensitivity = 50f;
    float xAxisRotation = 0f;

    public void Awake()
    {
        fixedJoystick_look = GameObject.FindWithTag("Joystick_look").GetComponent<FixedJoystick>();
    }
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        PlayerYaxisRotation();
        PlayerXaxisRotation();
    }

    private void PlayerYaxisRotation()
    {
        float inputMouseX = fixedJoystick_look.Horizontal * mouseSensitivity * Time.deltaTime;
        playerTarget.Rotate(Vector3.up * inputMouseX);
    }
    private void PlayerXaxisRotation()
    {
        float inputMouseY = fixedJoystick_look.Vertical * mouseSensitivity * Time.deltaTime;

        xAxisRotation += inputMouseY;
        xAxisRotation = Mathf.Clamp(xAxisRotation, -45, 45);
        //transform.localRotation = Quaternion.Euler(-xAxisRotation, 0f, 0f);
        //playerTarget.Rotate(Vector3.right * xAxisRotation/80);
        playerTarget2.localRotation = Quaternion.Euler(-xAxisRotation, 0f, 0f);
    }
    
}

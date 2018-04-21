using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{

    private float walkSpeed = 4.0f;
    private float lookSpeed = 2.0f;

    public Transform eyeCamera;

    public CharacterController controller;
    private bool canLook;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        DoMouseLock();
        DoMovement();
        if(canLook)
            DoLooking();
    }

    private void DoMouseLock()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            canLook = true;
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.F1))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            canLook = false;
        }
    }

    private void DoLooking()
    {
        float rotation = Input.GetAxisRaw("Mouse X");
        float pitch = -Input.GetAxisRaw("Mouse Y");

        transform.Rotate(Vector3.up, rotation * lookSpeed);
        eyeCamera.transform.Rotate(Vector3.right, pitch * lookSpeed);
    }

    private void DoMovement()
    {
        Vector3 moveInput = transform.right * Input.GetAxisRaw("Horizontal") + transform.forward * Input.GetAxisRaw("Vertical");
        moveInput.Normalize();

        controller.SimpleMove(moveInput * walkSpeed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    // Viewports
    public GameObject RegularViewport;
    public GameObject OtherViewport;

    // Player movement settings
    public float walkSpeed = 6f;
    public float runSpeed = 12f;
    public float jumpPower = 7f;
    public float gravity = 10f;
    public float lookSpeed = 2f;
    public float lookXLimit = 45f;
    public float defaultHeight = 2f;
    public float crouchHeight = 1f;
    public float crouchSpeed = 3f;

    private Vector3 moveDirection = Vector3.zero;
    private float rotationX = 0;
    private CharacterController characterController;
    private int toggle = 1; // 1 for RegularViewport, 2 for OtherViewport

    private bool canMove = true; // Controls whether the player can move

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // Ensure the RegularViewport is active at start
        RegularViewport.SetActive(true);
        OtherViewport.SetActive(false);
    }

    void Update()
    {
        // Handle viewport toggling
        if (Input.GetKeyDown("e"))
        {
            if (toggle == 1)
            {
                SwitchToOtherViewport();
                toggle = 2;
            }
            else
            {
                SwitchToRegularViewport();
                toggle = 1;
            }
        }

        // Camera rotation (always enabled)
        float mouseX = Input.GetAxis("Mouse X") * lookSpeed;
        float mouseY = -Input.GetAxis("Mouse Y") * lookSpeed;

        rotationX += mouseY;
        rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);

        // Rotate active camera
        if (RegularViewport.activeSelf)
        {
            RegularViewport.GetComponentInChildren<Camera>().transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        }
        else if (OtherViewport.activeSelf)
        {
            OtherViewport.GetComponentInChildren<Camera>().transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        }

        // Rotate player for horizontal input
        transform.rotation *= Quaternion.Euler(0, mouseX, 0);

        // Apply gravity to always ensure falling
        ApplyGravity();

        // Disable movement in OtherViewport
        if (!canMove) return;

        // Player movement
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float curSpeedX = (isRunning ? runSpeed : walkSpeed) * Input.GetAxis("Vertical");
        float curSpeedY = (isRunning ? runSpeed : walkSpeed) * Input.GetAxis("Horizontal");
        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);

        if (Input.GetButton("Jump") && characterController.isGrounded)
        {
            moveDirection.y = jumpPower;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }

        // Handle crouching
        if (Input.GetKey(KeyCode.R))
        {
            characterController.height = crouchHeight;
            walkSpeed = crouchSpeed;
            runSpeed = crouchSpeed;
        }
        else
        {
            characterController.height = defaultHeight;
            walkSpeed = 6f;
            runSpeed = 12f;
        }

        // Apply movement
        characterController.Move(moveDirection * Time.deltaTime);
    }

    void ApplyGravity()
    {
        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
            characterController.Move(new Vector3(0, moveDirection.y, 0) * Time.deltaTime);
        }
    }

    void SwitchToRegularViewport()
    {
        RegularViewport.SetActive(true);
        OtherViewport.SetActive(false);
        canMove = true; // Enable player movement
    }

    void SwitchToOtherViewport()
    {
        RegularViewport.SetActive(false);
        OtherViewport.SetActive(true);
        canMove = false; // Disable player movement but allow looking around
    }
}
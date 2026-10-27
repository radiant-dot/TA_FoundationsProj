
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.TextCore.Text;

public class CharacterMovement : MonoBehaviour
{
    public Camera cam;
    private Vector2 mouseMovement;
    private float xRotation;
    private float yRotation;
    public float lookSpeed;
    CharacterController controller;
    private Vector3 playerVelocity;
    public float gravity = 9.8f;
    private Vector3 movementInput;
    public float movementSpeed = 10f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        mouseMovement = Input.mousePositionDelta; //get movement of mouse
        movementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")); //get movement input based on axis input

        MovePlayer();
        MoveCamera();
    }

    void MovePlayer()
    {
        Vector3 moveVector = transform.TransformDirection(movementInput); //convert movement from local to world transform
        
        if (controller.isGrounded) //push player into the ground if on ground
        {
            playerVelocity.y = -1f;
        }
        else //if not on ground, apply gravity
        {
            playerVelocity.y += gravity * -2f * Time.deltaTime;
        }

        controller.Move(moveVector * movementSpeed * Time.deltaTime); //apply movement input
        controller.Move(playerVelocity * Time.deltaTime); //apply fall speed
    }

    void MoveCamera()
    {
        xRotation -= mouseMovement.y * Time.deltaTime * lookSpeed; //get vertical camera movement
        xRotation = Mathf.Clamp(xRotation, -90, 90); //clamp to prevent player from looking too far up or down
        yRotation += mouseMovement.x  * Time.deltaTime * lookSpeed; //get horizontal camera movement
        
        transform.rotation = Quaternion.Euler(0,yRotation,0); //apply horizontal rotation
        cam.transform.localRotation = Quaternion.Euler(xRotation,0,0); //apply vertical rotation
    }
}

//code borrowed from https://github.com/D-three/First-Person-Movement-Script-For-Unity/blob/main/First_Person_Movement.cs

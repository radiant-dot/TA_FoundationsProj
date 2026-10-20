using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.TextCore.Text;

public class CharacterMovement : MonoBehaviour
{
    public Camera cam;
    private UnityEngine.Vector2 mouseMovement;
    private float xRotation;
    private float yRotation;
    public float lookSpeed;
    CharacterController controller;
    private UnityEngine.Vector3 playerVelocity;
    public float gravity = 9.8f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        mouseMovement = Input.mousePositionDelta;
        xRotation -= mouseMovement.y * Time.deltaTime * lookSpeed;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        yRotation += mouseMovement.x  * Time.deltaTime * lookSpeed;
        
        transform.rotation = UnityEngine.Quaternion.Euler(0,yRotation,0);
        cam.transform.localRotation = UnityEngine.Quaternion.Euler(xRotation,0,0);
    }

    void FixedUpdate()
    {
        if(controller.isGrounded == false)
        {
            playerVelocity.y -= gravity;
        }
        controller.Move(playerVelocity);
    }
}

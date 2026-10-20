using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class CharacterMovement : MonoBehaviour
{
    public Camera cam;
    Vector2 mouseMovement;
    private float xRotation;
    private float yRotation;
    public float lookSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mouseMovement = Input.mousePositionDelta;
        xRotation -= mouseMovement.y * Time.deltaTime * lookSpeed;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        yRotation += mouseMovement.x  * Time.deltaTime * lookSpeed;
        
        transform.rotation = Quaternion.Euler(0,yRotation,0);
        cam.transform.localRotation = Quaternion.Euler(xRotation,0,0);
    }
}

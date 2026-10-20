using UnityEngine;
using UnityEngine.UIElements;

public class MoveAround : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;

    void Start()
    {
        
    }
    
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(0,0,1);
            Debug.Log("right arrow pressed");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(0,0,-1);
            Debug.Log("left arrow pressed");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0,1,0);
            Debug.Log("up arrow pressed");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0,-1,0);
            Debug.Log("down arrow pressed");
        }*/

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(transform.forward*movementSpeed*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-transform.forward*movementSpeed*Time.deltaTime);  
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(transform.up*rotationSpeed*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate((-1)*transform.up*rotationSpeed*Time.deltaTime);
        }
    }
}

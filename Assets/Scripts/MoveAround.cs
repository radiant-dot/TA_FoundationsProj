using UnityEngine;

public class MoveAround : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
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
        }
    }
}

using UnityEngine;
//This script is to destroy a game object using the space bar
public class PushSpaceToDestroy : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}

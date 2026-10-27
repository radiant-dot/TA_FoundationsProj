using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // My name is hi
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        animator.SetBool("IsClicked", true);
    }
}

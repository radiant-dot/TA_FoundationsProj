using UnityEngine;

public class chestScript : MonoBehaviour
{

    public Animator animator;
    public bool open = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
;   }

    private void OnMouseDown()
    {
        if (open == false)
        {
            animator.SetTrigger("chestOpen");
            open = true;
        }
    }
}

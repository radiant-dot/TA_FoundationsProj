using Unity.VisualScripting;
using UnityEngine;

public class chestScript : MonoBehaviour
{

    public Animator animator;
    public bool open = false;

    public GameObject UIIcon;
    public GameObject player;

    float distance;
    public float interactRadius = 2.5f;
    float lastDistance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interactRadius = 2.5f;
        animator = GetComponent<Animator>();
        player = GameObject.Find("player");
;   }

    private void Update()
    {
        distance = Vector3.Distance(gameObject.transform.position, player.transform.position);
        if (lastDistance < interactRadius & distance >= interactRadius)
        {
            UIIcon.GetComponent<indicator>().showChest(false);
        }
        lastDistance = distance;
    }

    private void OnMouseDown()
    {
        if (open == false & distance < interactRadius)
        {
            animator.SetTrigger("chestOpen");
            open = true;
            gameObject.layer = 2;
        }
    }

    private void OnMouseOver()
    {
        if (distance < interactRadius)

        {
            Debug.Log(distance + ", " + interactRadius);
            UIIcon.GetComponent<indicator>().showChest(true);
        }
    }

    private void OnMouseExit()
    {
        UIIcon.GetComponent<indicator>().showChest(false);
    }


}

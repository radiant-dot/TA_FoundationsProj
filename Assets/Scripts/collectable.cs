using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class collectable : MonoBehaviour
{
    Animator animator;
    public GameObject collector;
    public GameObject parent;
    public GameObject UIIcon;
    public GameObject player;
    public RawImage scroll;

    float distance;
    public float interactRadius =2.5f;
    float lastDistance;

    public string myName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interactRadius = 2.5f;
        animator = GetComponent<Animator>();
        parent = gameObject.transform.parent.gameObject;
        player = GameObject.Find("player");

    }

    private void Update()
    {
        distance = Vector3.Distance(gameObject.transform.position, player.transform.position);
        if(lastDistance < interactRadius & distance >= interactRadius)
        {
            UIIcon.GetComponent<indicator>().showHand(false);
        }
        lastDistance = distance;
    }

    void OnMouseDown()
    {
        if (distance < interactRadius)
        {
            parent.transform.position = collector.transform.position;
            GetComponent<Collider>().enabled = false;
            animator.SetTrigger("collected");
            scroll.GetComponent<collectController>().Collect(myName);
        }
    }

    public void deleteObject()
    {
        Destroy(gameObject);
    }

    private void OnMouseOver()
    {
        if(distance < interactRadius)
        {
            UIIcon.GetComponent<indicator>().showHand(true);
        }
    }

    private void OnMouseExit()
    {
        UIIcon.GetComponent<indicator>().showHand(false);
    }
}


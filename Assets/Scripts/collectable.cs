using System;
using Unity.VisualScripting;
using UnityEngine;

public class collectable : MonoBehaviour
{
    Animator animator;
    [SerializeField] GameObject collector;
    public GameObject parent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        parent = gameObject.transform.parent.gameObject;
    }

    void OnMouseDown()
    {
        parent.transform.position = collector.transform.position;
        GetComponent<Collider>().enabled = false;
        animator.SetTrigger("collected");
    }

    void deleteObject()
    {
        Destroy(gameObject);
    }

    private void OnMouseOver()
    {
        
    }
}


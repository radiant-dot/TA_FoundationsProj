using System;
using UnityEngine;

public class collectable : MonoBehaviour
{
    Animator animator;
    [SerializeField] GameObject collector;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        transform.position = collector.transform.position;
        animator.SetTrigger("collected");
    }
}

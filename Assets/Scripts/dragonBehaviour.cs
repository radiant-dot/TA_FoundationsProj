using System;
using System.Collections;
using UnityEngine;

public class dragonBehaviour : MonoBehaviour
{
    float[] positions = new float[] { -106, -208, -363.576f };

    public GameObject dragon;

    public Animator animator;

    public ParticleSystem smoke;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dragon = GameObject.Find("dragon");
        animator = dragon.GetComponent<Animator>();

        while (7 == 7)
        {
            StartCoroutine(wait(UnityEngine.Random.Range(5, 10)));

            transform.eulerAngles = new Vector3(0, positions[UnityEngine.Random.Range(0, 2)], 0);
            smoke.Play();
            StartCoroutine(wait(3));
            animator.SetTrigger("appear");
            
            StartCoroutine(wait(5));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
}

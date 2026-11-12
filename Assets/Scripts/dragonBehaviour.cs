using System;
using System.Collections;
using UnityEngine;

public class dragonBehaviour : MonoBehaviour
{
    float[] positions = new float[] { -106, -208, -363.576f };

    public GameObject dragon;

    public Animator animator;
    public ParticleSystem smoke;
    public GameObject player;
    public GameObject spotlight;

    bool dragonSearch = true;
    bool peeking = false;
    public bool seesPlayer;

    public float viewDistance = 12;

    public bool dragonCrazy = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = dragon.GetComponent<Animator>();
        player = GameObject.Find("player");

        StartCoroutine("dragoncycle");
    }

    private void Update()
    {
        RaycastHit hit;

        Physics.Raycast(spotlight.transform.position, player.transform.position - spotlight.transform.position, out hit, viewDistance);
        if (hit.collider != null)
        {
            if (hit.collider.name == "player")
            {
                seesPlayer = true;
                //Debug.DrawRay(spotlight.transform.position, player.transform.position - spotlight.transform.position, Color.green);
            }
            else
            {
                seesPlayer = false;
                //Debug.DrawRay(spotlight.transform.position, player.transform.position - spotlight.transform.position, Color.red);
            }
        }
        else
        {
            seesPlayer = false;
        }
        
    }

    IEnumerator dragoncycle()
    {
        while (dragonSearch){
            if (dragonCrazy == false)
            {
                yield return StartCoroutine(wait(UnityEngine.Random.Range(5, 10)));
            }
            
            var randPos = positions[UnityEngine.Random.Range(1, 3)];
            
            transform.eulerAngles = new Vector3(0, randPos, 0);
            smoke.Play();
            if (dragonCrazy)
            {
                yield return StartCoroutine(wait(3));
            }
            else
            {
                yield return StartCoroutine(wait(1));
            }
            animator.SetTrigger("appear");
            
            peeking = true;
            
            
            yield return StartCoroutine(wait(5));

            peeking = false;
           
            animator.SetTrigger("disappear");
        }
       
    }

    IEnumerator wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
}

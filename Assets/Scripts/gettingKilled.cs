using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using UnityEngine.SceneManagement;

public class gettingKilled : MonoBehaviour
{
    public ParticleSystem fire;
    public GameObject dragon;
    public dragonBehaviour dragonScript;
    public Camera cam;
    public Slider healthBar;
    public GameObject deathScreen;

    public Animator animator;

    public CharacterMovement charMovement;

    float health = 100;
    float maxHealth = 100;


    private void Start()
    {
        dragonScript = dragon.GetComponent<dragonBehaviour>();
        charMovement = gameObject.GetComponent<CharacterMovement>();

        animator = cam.GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (dragonScript.seesPlayer == true)
        {
            if(fire.isPlaying == false){
                fire.Play();
                
            }
            health -= 1;
        }
        else
        {
            fire.Stop();
            if (health < maxHealth)
            {
                health += 1;
            }
            
        }

        if(health <= 0)
        {
            StartCoroutine(Die());
        }

        healthBar.value = health;
    }

    IEnumerator Die()
    {
        charMovement.enabled = false;
        animator.enabled = true;
        animator.SetTrigger("died");
        enabled = false;

        yield return new WaitForSeconds(1.5f);
        deathScreen.SetActive(true);

        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("000_MainMenu");
    }
}

using UnityEngine;

public class gettingKilled : MonoBehaviour
{
    public ParticleSystem fire;
    public GameObject dragon;
    public dragonBehaviour dragonScript;

    float health = 100;
    float maxHealth = 100;


    private void Start()
    {
        dragonScript = dragon.GetComponent<dragonBehaviour>();
    }

    private void FixedUpdate()
    {
        if (dragonScript.seesPlayer == true)
        {
            fire.Play();
            health -= 1;
        }
        else
        {
            fire.Stop();
            health += 1;
        }

        if(health <= 0)
        {

        }
    }
}

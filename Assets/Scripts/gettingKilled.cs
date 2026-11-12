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

    private void Update()
    {
        if(dragonScript.seesPlayer = true)
        {
            dragonscript
        }
    }
}

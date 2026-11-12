using UnityEngine;
using UnityEngine.UI;

public class collectController : MonoBehaviour
{
    int treasuresFound = 0;
    bool onscreen;


    public GameObject dragon;
    public dragonBehaviour dragonScript;
    public GameObject wayOut;
    Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        dragon = GameObject.Find("dragonpos");
        dragonScript = dragon.GetComponent<dragonBehaviour>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (onscreen)
            {
                animator.SetTrigger("offscreen");
                onscreen = false;
            }
            else
            {
                animator.SetTrigger("onscreen");
                onscreen = true;
            }
        }
        
    }

    public void Collect(string name)
    {   
        if(GameObject.Find(name + "Mark").GetComponent<RawImage>().enabled == false)
        {
            GameObject.Find(name + "Mark").GetComponent<RawImage>().enabled = true;
            treasuresFound +=1;

            if(treasuresFound >= 5)
            {
                dragonScript.dragonCrazy = true;
                wayOut.GetComponent<Collider>().enabled = false;
            }
        }
    }
}

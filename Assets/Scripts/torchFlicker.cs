using UnityEngine;

public class torchFlicker : MonoBehaviour
{
    Light light;

    void Start()
    {
        light = GetComponent<Light>();
    }
    // Update is called once per frame
    void Update()
    {
        light.intensity += Random.Range(-1.0f, 1.0f);
    }
}

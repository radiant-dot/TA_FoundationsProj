using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winDetect : MonoBehaviour
{

    public GameObject winScreen;

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "player")
        {
            StartCoroutine(Win());
        }
    }

    IEnumerator Win()
    {
        winScreen.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("000_MainMenu");
    }
}

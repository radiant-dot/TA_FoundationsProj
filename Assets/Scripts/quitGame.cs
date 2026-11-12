using UnityEngine;

public class quitGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void QuitGame()
    {
        Debug.Log("Quitted game");
        Application.Quit();
    }
}

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("001_MainSceneTower");
    }
}

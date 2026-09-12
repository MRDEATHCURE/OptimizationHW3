using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("Level 1");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
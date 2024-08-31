using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Settings()
    {
        // SceneManager.LoadScene("OptionsMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Starttgame()
    {
        SceneManager.LoadScene("Scene01");
    }

    public void Exit()
    {
        Application.Quit();
    }
}

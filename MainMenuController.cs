using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Called when the Play button is clicked
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene"); // Load the SampleScene
    }

    // Called when the Quit button is clicked
    public void QuitGame()
    {
        Application.Quit(); // Quit the game
    }
}
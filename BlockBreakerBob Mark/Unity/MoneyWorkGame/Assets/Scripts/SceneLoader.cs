using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Gaat naar volgende scherm
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // Kan een scherm overslaan om bij gameover te komen
    public void LoadskipOneScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 2);
    }
    
    // Gaat naar eerste scherm na play again
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    // Sluit spel af
    public void QuitGame()
    {
        Application.Quit();
    }
}
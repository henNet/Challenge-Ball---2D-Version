using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    /* Scriptable Objects */
    public LevelSettingsScriptObj levelSettings;
    public PlayerSettingsScriptObj playerSettings;

    private void Start()
    {
        levelSettings.resetLevelIndex();
        playerSettings.resetLife();
    }

    public void LoadScene(String sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

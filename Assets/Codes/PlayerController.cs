using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    /* Scriptable Objects */
    public LevelSettingsScriptObj levelSettings;
    public PlayerSettingsScriptObj playerSettings;

    private void Start()
    {
        LevelController.Instance.setUITextOfLifePlayer(playerSettings.life);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
            if (playerSettings.life > 1)
            {
                playerSettings.life--;
                LevelController.Instance.setUITextOfLifePlayer(playerSettings.life);
                Invoke(nameof(resetLevel), 1.0f);
            }
            else
            {
                LevelController.Instance.setUITextOfLifePlayer(0);
                playerSettings.resetLife();
                LevelController.Instance.enablePanelGameOver();
                Invoke(nameof(gameOver), 1.0f);
            }
            LevelController.Instance.playSoundDeathBall();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            playerSettings.resetLife();/* Easy mode */
            levelSettings.levelIndex++;
            //Destroy(LevelController.Instance.audioLevel);
            SceneManager.LoadScene(levelSettings.levelNames[levelSettings.levelIndex]);
        }
    }

    private void resetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void gameOver()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

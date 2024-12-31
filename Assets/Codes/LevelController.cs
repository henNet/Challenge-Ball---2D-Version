using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    /* UI */
    public TMP_Text txtLifePlayer;
    public GameObject panelGameOver;
    public GameObject panelPause;

    /* Audio Source */
    public AudioSource soundDeathBall;

    private bool isPause = false;

    /* Padrão Singleton */
    public static LevelController Instance { get; private set; }

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void setUITextOfLifePlayer(int life)
    {
        txtLifePlayer.text = "Vidas: " + life;
    }

    public void enablePanelGameOver()
    {
        panelGameOver.SetActive(true);
        panelGameOver.GetComponent<Animator>().SetTrigger("GameOver");
    }

    public void setPanelPause(int value)
    {
        Time.timeScale = value;
        panelPause.SetActive(value == 0 ? true : false);
        isPause = value == 0 ? true : false;
    }

    public void loadMainMenu()
    {
        if (isPause)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void playSoundDeathBall()
    {
        soundDeathBall.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScenesControler : MonoBehaviour
{
    private static SoundScenesControler instance = null;
    public static SoundScenesControler Instance
    {
        get { return instance; }
    }

    /* Parâmetros Gerais */
    private AudioSource menuTheme;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
        menuTheme = GetComponent<AudioSource>();
    }

    public void playMenuTheme()
    {
        menuTheme.Play();
    }

    public void stopMenuTheme()
    {
        menuTheme.Stop();
    }

    public void setVolumeThemeSound(float volume)
    {
        menuTheme.volume = volume;
    }
}

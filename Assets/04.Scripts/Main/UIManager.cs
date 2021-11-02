using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    void Awake()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.SetResolution(600, 1024, true);
    }

    public void OnStartClick()
    {
        SceneManager.LoadScene("Play");
    }
    public void OnExitClick()
    {
        Application.Quit();
    }
    public void OnHowToPlayClick()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public AudioClip sfx;
    public AudioSource audioSource;

    void Start()
    {
        audioSource.PlayOneShot(sfx, 0.3f);
    }
}

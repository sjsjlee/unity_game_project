using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour {


	void Update ()
    {
        if (Input.GetKeyDown("r")) 
        {
            SceneManager.LoadScene("Main");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }

    public AudioClip sfx;
    public AudioSource audioSource;

    void Start()
    {
        audioSource.PlayOneShot(sfx, 0.3f);
    }
}

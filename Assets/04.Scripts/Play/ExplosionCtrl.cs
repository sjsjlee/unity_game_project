using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionCtrl : MonoBehaviour
{

    public AudioClip sfx;
    public AudioSource audioSource;



    void Start()
    {
        audioSource.PlayOneShot(sfx, 0.05f);
        Invoke("destroy", 0.5f);
    }
    void destroy()
    {
        Destroy(this.gameObject);
    }



}

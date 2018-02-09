using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnSplash : MonoBehaviour {
    public AudioSource audioSource;

    public void OpenSplash()
    {
        SceneManager.LoadScene("Splash");
    }

    public void PlaySound()
    {
        audioSource.Play();
    }

}

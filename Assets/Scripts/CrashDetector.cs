using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] AudioClip crashSFX;
    bool unhit = true;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Snow" && unhit)
        {
            FindObjectOfType<PlayerController>().DisableControls();
            GetComponent<AudioSource>().Play();
            Invoke("ResetTheScene", 1f);
            unhit = false;
        }
    }
    void ResetTheScene()
    {
        SceneManager.LoadScene(0);
    }
}

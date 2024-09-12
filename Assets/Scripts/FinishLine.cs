 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    bool untouched = true;

    [SerializeField] float delay = 1.0f;
    [SerializeField] ParticleSystem finishEffect;
    /*void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == ("Harry"))
        Debug.Log(nothing);
    }*/
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Harry" && untouched)
        {
            GetComponent<AudioSource>().Play();
            Invoke("ResetTheScene", delay);
            untouched = false;
        }
    }
    void ResetTheScene()
    {
        SceneManager.LoadScene(0);
    }
}

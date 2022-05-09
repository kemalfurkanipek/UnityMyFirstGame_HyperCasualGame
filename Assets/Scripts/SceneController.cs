using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip AudioClip;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        PlaySes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void replay()
    {
        SceneManager.LoadScene(0);
    }

    public void PlaySes()
    {
        AudioSource.PlayOneShot(AudioClip);
    }
}

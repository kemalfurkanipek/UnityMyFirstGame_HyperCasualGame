using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//We're doing scene control here.
public class SceneController : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip AudioClip;  // GameOverSound
   
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        PlaySes();
    }


    public void replay()
    {
        SceneManager.LoadScene(0);  // this code go to playScene
    }

    public void PlaySes()
    {
        AudioSource.PlayOneShot(AudioClip);
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene(2); //this code go to HowToPlayScene
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(3); //this code go to EntryScene
    }

}

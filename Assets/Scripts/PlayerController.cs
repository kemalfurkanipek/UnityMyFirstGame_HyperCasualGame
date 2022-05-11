using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //The required variables are here.
    public int score = 0;         
    public float playerSpeed;
    public bool rightPs = true;
    public Text textScore, lifeScore; //ScoreText and LifeText                                     
    public int playerLife = 3;
    public AudioSource playerAudio;
    public AudioClip playerAudioClip, playerAudioClip1;     // CollidSound and EnemyCollidSound


    
    void Update()
    {
        changeAt();
        playerMove();

        textScore.text = score.ToString();
        lifeScore.text = "Life = " + playerLife.ToString();
        
        playerAudio = GetComponent<AudioSource>();
        



    }

    void playerMove()
    {
        if (rightPs)
        {
            transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);   // allows the player to move in the right direction
        }
        if (!rightPs)
        {
            transform.Translate(Vector2.left * playerSpeed * Time.deltaTime);    // allows the player to move in the left direction
        }

    }

    void changeAt()   //changes the direction of the player
    {
        if (Input.GetMouseButtonDown(0) && rightPs)     
        {
            rightPs = false;
        }
        else if (Input.GetMouseButtonDown(0) && !rightPs)
        {
            rightPs = true;
        }

    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "foodScore")    //controls collision with score
        {
            Destroy(collision.gameObject);
            score++;

        }
        if (collision.gameObject.tag == "bonusScore")   //controls collision with bonusPoint
        {
            Destroy(collision.gameObject);
            score += 2;
        }

        if (collision.gameObject.tag == "deadScore")   //controls collision with enemy
        {
            Destroy(collision.gameObject);
            playerLife--;
            playerAudio.PlayOneShot(playerAudioClip1);
            if (playerLife == 0)
            {

                SceneManager.LoadScene(1);    //game over when life runs out

            }

        }

        if (collision.gameObject.tag == "lifeBonus")  //controls collision with bonusLife
        {
            playerLife++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "left_right")    //controls collision with rightBox
        {
            rightPs = true;
            playerAudio.PlayOneShot(playerAudioClip);
        }
        else if (collision.gameObject.tag == "right_left")  //controls collision with leftBox
        {
            rightPs = false;
            playerAudio.PlayOneShot(playerAudioClip);
        }
    }





}

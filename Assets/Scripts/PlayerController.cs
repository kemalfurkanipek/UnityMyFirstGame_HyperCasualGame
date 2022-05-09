using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int score = 0;
    public float playerSpeed;
    public bool rightPs = true;
    public Text textScore,lifeScore;
    public int playerLife=3;
    public AudioSource playerAudio;
    public AudioClip playerAudioClip,playerAudioClip1;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        changeAt();
        playerMove();

        textScore.text=score.ToString();
        lifeScore.text="Life = "+playerLife.ToString();
        playerAudio=GetComponent<AudioSource>();

        //if (transform.position.x > 2.71f)
        //{
        //    transform.position = new Vector2(2.71f, transform.position.y);
        //}
        //if (transform.position.x < -1.75f)
        //{
        //    transform.position = new Vector2(-1.75f, transform.position.y);
        //}
       
        
    }

    void playerMove()
    {
        if (rightPs)
        {
            transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);
        }
        if (!rightPs)
        {
            transform.Translate(Vector2.left * playerSpeed * Time.deltaTime);
        }
        
    }

    void changeAt()
    {
        if(Input.GetMouseButtonDown(0) && rightPs )
        {
            rightPs = false;
        }
        else if(Input.GetMouseButtonDown(0) && !rightPs )
        {
            rightPs = true;
        }
        
    }
    
    //void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "left_right")
    //    {
    //        rightPs = true;
    //    }
    //    else if(collision.gameObject.tag == "right_left")
    //    {
    //        rightPs=false;
    //    }

    //}

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "foodScore")
        {
            Destroy(collision.gameObject);
            score++;
            
        }
        if (collision.gameObject.tag == "bonusScore")
        {
            Destroy(collision.gameObject);
            score+=2;
        }

        if (collision.gameObject.tag == "deadScore")
        {
            Destroy (collision.gameObject);
            playerLife--;
            playerAudio.PlayOneShot(playerAudioClip1);
            if(playerLife == 0)
            {
               
                SceneManager.LoadScene(1);
                
            }

            
            

           
            
        }

        if (collision.gameObject.tag == "left_right")
        {
            rightPs = true;
            playerAudio.PlayOneShot(playerAudioClip);
        }
        else if (collision.gameObject.tag == "right_left")
        {
            rightPs = false;
            playerAudio.PlayOneShot(playerAudioClip);
        }
    }

    
    


}

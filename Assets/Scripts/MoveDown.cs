using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    PlayerController playerC;
    public float cloudSpeed = 6;
    // Start is called before the first frame update
    void Start()
    {
        playerC=FindObjectOfType<PlayerController>();
        InvokeRepeating("speedPlus", 1, 3);

    }

    // Update is called once per frame
    void Update()
    {
        

        transform.Translate(Vector2.down * Time.deltaTime * cloudSpeed);
        


    }

    void speedPlus()
    {
        if (playerC.score  >3)
        {
            cloudSpeed++;
        }
    }
}

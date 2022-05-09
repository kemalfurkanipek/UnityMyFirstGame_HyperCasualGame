using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject[] spawnObject;
    public GameObject[] spawnObject2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawner", 0.5f, 0.8f);
        InvokeRepeating("spawner2", 1, 4);
        InvokeRepeating("spawner3", 4, 8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawner()
    {
        int index = Random.Range(0, 4);
        Instantiate(spawnObject[index], new Vector2( Random.Range(-2.39f, 2.4f),5.50f), spawnObject[index].transform.rotation);
    }

    void spawner2()
    {
        int index2=Random.Range(0, 3);
        Instantiate(spawnObject2[index2], new Vector2(-2.27f,-2.7f), spawnObject[index2].transform.rotation);

    }
    void spawner3()
    {
        int index2 = Random.Range(0, 3);
        Instantiate(spawnObject2[index2], new Vector2(2.4f, -2.7f), spawnObject[index2].transform.rotation);
    }



    
    
        
    
}

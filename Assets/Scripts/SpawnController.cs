using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    //lists of objects to generate
    public GameObject[] spawnObject;    
    public GameObject[] spawnObject2;
    public GameObject spawnLife;
   
    void Start()
    {
        InvokeRepeating("spawner", 0.5f, 0.8f);
        InvokeRepeating("spawner2", 1, 4);               //Controls the runtime of functions.
        InvokeRepeating("spawner3", 4, 8);
        InvokeRepeating("spawnerLife", 5, 15);
    }


    void spawner()
    {
        int index = Random.Range(0, 4);
        Instantiate(spawnObject[index], new Vector2(Random.Range(-2.39f, 2.4f), 5.50f), spawnObject[index].transform.rotation); //Enemy is generated randomly
    }

    void spawnerLife()
    {
        Instantiate(spawnLife, new Vector2(Random.Range(-2.39f, 2.4f), 5.50f), spawnLife.transform.rotation); //Life is generated randomly
    }

    void spawner2()
    {
        int index2 = Random.Range(0, 3);
        Instantiate(spawnObject2[index2], new Vector2(-2.27f, -2.7f), spawnObject[index2].transform.rotation);  //ScorePoints are generated randomly

    }
    void spawner3()
    {
        int index2 = Random.Range(0, 3);
        Instantiate(spawnObject2[index2], new Vector2(2.4f, -2.7f), spawnObject[index2].transform.rotation); //Bonus Score is generated randomly
    }







}

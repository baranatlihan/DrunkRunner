using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnveriomentSpawner : MonoBehaviour
{
    [Header("Spawner Settings")]
    public GameObject[] items;
    public bool LeftSpawner = true;


    private float SpawnTime = 0f;
    private float timer = 0f;
    System.Random random = new System.Random();
    void Start()
    {
        SpawnTime = GameManager.staticSpawnTime;
    }


    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= GameManager.staticSpawnTime)
        {
            timer = 0f;
            if (LeftSpawner)
                SpawnObjectsL();
            else
            {
                SpawnObjectsR();
            }
        }
    }


    void SpawnObjectsL()
    {        
        Instantiate(items[random.Next(0, 256) % items.Length], transform.position, Quaternion.identity, transform.parent);       
    }

    void SpawnObjectsR()
    {       
        Instantiate(items[random.Next(0, 128) % items.Length], transform.position, Quaternion.Euler(0, 180, 0), transform.parent);     
    }
}


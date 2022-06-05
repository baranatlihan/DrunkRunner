using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSpawner : MonoBehaviour
{
    [Header("Spawner Settings")]
    public GameObject[] items;
    public bool LeftSpawner = true;
    public bool efective = false;
    [Tooltip("Spawn points for efective objects.")]
    public Transform[] spawnPoints;
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

        if (timer >= GameManager.staticSpawnTime+5)
        {
            timer = 0f;
            if (efective)
            {
                SpawnEfectiveObjects();
            }
        }
    }


    void SpawnEfectiveObjects()
    {
        for(int i = 0;i<spawnPoints.Length;i++)
        Instantiate(items[random.Next(0, 128) % items.Length], spawnPoints[i].transform.position, Quaternion.Euler(0, 180, 0), transform.parent);
 
    }
}


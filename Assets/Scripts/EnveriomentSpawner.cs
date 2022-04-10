using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnveriomentSpawner : MonoBehaviour
{
    [Header("Spawner Settings")]
    public GameObject[] items;
    public float SpawnTime = 0f;
    public bool LeftSpawner = true;

    private float timer = 0f;
    System.Random random = new System.Random();
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= SpawnTime)
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
        if (items.Length != 0)
        {
            Instantiate(items[random.Next(0, items.Length)], transform.position, Quaternion.identity, transform.parent);
        }
        else
            Instantiate(items[random.Next(0, items.Length)], transform.position, Quaternion.identity, transform.parent);
    }

    void SpawnObjectsR()
    {
        if (items.Length != 0)
        {
            Instantiate(items[random.Next(0, items.Length)], transform.position, Quaternion.Euler(0,180,0), transform.parent);
        }
        else
            Instantiate(items[random.Next(0, items.Length)], transform.position, Quaternion.Euler(0, 180, 0), transform.parent);
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnceSpawn : MonoBehaviour
{

    [Header("Spawner Settings")]
    public GameObject[] items;

    [Tooltip("Spawn points for efective objects.")]
    public Transform[] spawnPoints;
    System.Random random = new System.Random();


    // Start is called before the first frame update
    void Start()
    {
        SpawnOnce();
    }

   
    void SpawnOnce()
    {
        for(int i = 0;i<spawnPoints.Length;i++)
        Instantiate(items[random.Next(0, 128) % items.Length], spawnPoints[i].transform.position, Quaternion.Euler(0, 180, 0), transform.parent);
    }
}

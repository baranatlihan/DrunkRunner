using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSpawnerScript : MonoBehaviour
{
    public GameObject[] toSpawns;
    
    System.Random random = new System.Random();
    Bounds bound;

    void Start()
    {
        bound = new Bounds(transform.position, new Vector3(4.5f, 0, 7.4f));
        
        for (int i = 0; i < 100; i++)
        {
            Instantiate(toSpawns[random.Next(0, 128) % toSpawns.Length], RandomPoint(bound), Quaternion.identity);
        }
            
    }

    public static Vector3 RandomPoint(Bounds bound)
    {
        return new Vector3(
        Random.Range(bound.min.x, bound.max.x),
        Random.Range(bound.min.y, bound.max.y),
        Random.Range(bound.min.z, bound.max.z)
    );
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [Header("Level Settings")]
    public float levelTime = 0;

    [Header("Object Settings")]
    public float FlowSpeed = 0;
    public float SpawnTime = 0;

    static public float ControlTime = 0f;
    static public float staticLevelTime = 0f;
    static public float staticSpeed = 0f;
    static public float staticSpawnTime = 0;
    private void Awake()
    {
        Time.timeScale = 1;
        staticLevelTime = levelTime;
        staticSpeed = FlowSpeed;
        staticSpawnTime = SpawnTime;
    }
    void Start()
    {
        ControlTime = 0f;
    }


    void Update()
    {
        ControlTime += Time.deltaTime;
        staticSpeed += Time.deltaTime/3;        


        staticSpawnTime = staticSpawnTime - Time.deltaTime / 50;
        if (staticSpawnTime <= 0.25f)
        {
            staticSpawnTime = 0.25f;
        }

        Debug.Log(ControlTime);
    }
}

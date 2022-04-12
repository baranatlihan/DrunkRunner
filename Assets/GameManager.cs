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

    [Header("Efective Object Settings")]
    public float EfectiveSpawnTime = 0;

    [Header("Player")]
    public GameObject player;

    static public float ControlTime = 0f;
    static public float staticLevelTime = 0f;
    static public float staticSpeed = 0f;
    static public float staticSpawnTime = 0;
    static public float staticEfectiveSpawnTime = 0;
    static public GameObject staticPlayer;
    private void Awake()
    {
        Time.timeScale = 1;
        staticLevelTime = levelTime;
        staticSpeed = FlowSpeed;
        staticSpawnTime = SpawnTime;
        staticEfectiveSpawnTime = EfectiveSpawnTime;
        staticPlayer = player;


    }
    void Start()
    {
        ControlTime = 0f;
    }


    void Update()
    {
        Debug.Log(ControlTime);
        ControlTime += Time.deltaTime;
        if (staticSpeed < 27)
        {
            staticSpeed += Time.deltaTime / 3;
        }
        else
        {
            staticSpeed = 27;
        }
     


        staticSpawnTime = staticSpawnTime - Time.deltaTime / 50;
        if (staticSpawnTime <= 0.40f)
        {
            staticSpawnTime = 0.40f;
        }


        staticEfectiveSpawnTime = staticEfectiveSpawnTime - Time.deltaTime / 20;
        if (staticEfectiveSpawnTime <= 0.5f)
        {
            staticEfectiveSpawnTime = 0.5f;
        }

        //Debug.Log(ControlTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [Header("Level Settings")]
    public float levelTime = 0;

    [Header("Object Flow Settings")]
    public float FlowSpeed = 0;

    static public float ControlTime = 0f;
    static public float staticLevelTime = 0f;
    static public float staticSpeed = 0f;
    private void Awake()
    {
        Time.timeScale = 1;
        staticLevelTime = levelTime;
        staticSpeed = FlowSpeed;
    }
    void Start()
    {
        ControlTime = 0f;
    }


    void Update()
    {
        ControlTime += Time.deltaTime;
    }
}

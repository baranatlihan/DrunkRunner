using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject[] willDisableItems;
    public GameObject spawner;

    private void Awake()
    {
        spawner.SetActive(false);
    }
    void Update()
    {
        if(GameManager.staticLevelTime < GameManager.ControlTime)
        {
            for(int i = 0; i < willDisableItems.Length; i++)
            {
                willDisableItems[i].SetActive(false);
                spawner.SetActive(true);
            }
            //spawnScoreHumans();
        }

    }


}

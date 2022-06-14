using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject[] willDisableItems;
    public GameObject spawner;


    private void Awake()
    {
        Time.timeScale = 0;
        spawner.SetActive(false);
    }

    void Update()
    {
        if(GameManager.staticLevelTime - 5 < GameManager.ControlTime)
        {
            for(int i = 0; i < willDisableItems.Length; i++)
            {
                willDisableItems[i].SetActive(false);
                spawner.SetActive(true);
            }
        }
         if(GameManager.staticLevelTime + 5 < GameManager.ControlTime)
        {
            SceneManager.LoadScene(0);
        }


    }


}

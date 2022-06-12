using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFlow : MonoBehaviour
{
    private Vector3 speedVec = new Vector3(0, 0, 0);
    public float speed = 0f;
    public bool opositeWay = false;

    void Start()
    {
        if (!opositeWay)
        {
            speed = GameManager.staticSpeed;
            speedVec.Set(0, 0, -speed);
        }
        else
        {
            speed = GameManager.staticSpeed;
            speedVec.Set(0, 0, speed);
        }
        
    }


    void Update()
    {
        if (!opositeWay)
        {
            speed = GameManager.staticSpeed;
            speedVec.Set(0, 0, -speed);
            gameObject.transform.localPosition += speedVec * Time.deltaTime;
        }
        else
        {
            speed = GameManager.staticSpeed;
            speedVec.Set(0, 0, speed);
            gameObject.transform.localPosition += speedVec * Time.deltaTime;
        }
            
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(this.gameObject);
        }
        else if ((this.tag == "Bottle" || this.tag == "Harmfull") && other.gameObject.tag == "Player") 
        {
            this.transform.GetChild(0).gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (this.CompareTag("Harmfull"))
            {
                PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") - 3);
            }
            else
            {
                PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 2);
            }

            Destroy(this.gameObject);
        }
    }

}

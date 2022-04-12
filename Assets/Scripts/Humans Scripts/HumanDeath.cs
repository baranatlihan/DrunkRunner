using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class HumanDeath : MonoBehaviour
{
    [HideInInspector]
    public float speed = 0f;

    public GameObject ragdolObj;
    private Vector3 speedVec = new Vector3(0, 0, 0);
    private string tagName;



    void Start()
    {
        speed = GameManager.staticSpeed;
        speedVec.Set(0, 0, -speed);
    }
    private void Update()
    {
        speed = GameManager.staticSpeed;
        speedVec.Set(0, 0, -speed);
        gameObject.transform.localPosition += speedVec * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //for playerprefs: example on last game-> PlayerPrefs.SetInt("deadCount", PlayerPrefs.GetInt("deadCount") + 1);
            Destroy(this.gameObject);
            Instantiate(ragdolObj, transform.position, Quaternion.identity, transform.parent);
        }

        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(this.gameObject);
        }



    }
}

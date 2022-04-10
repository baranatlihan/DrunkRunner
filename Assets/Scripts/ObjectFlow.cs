using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFlow : MonoBehaviour
{
    private Vector3 speedVec = new Vector3(0, 0, 0);

    public float speed = 0f;

    private bool control = true;
    void Start()
    {
        speed = GameManager.staticSpeed;
        control = true;
        speedVec.Set(0, 0, -speed);
    }


    void Update()
    {
        if (control)
        {
            gameObject.transform.localPosition += speedVec * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(this.gameObject);
        }
    }

}

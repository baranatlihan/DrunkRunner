using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollTrigger : MonoBehaviour
{

    System.Random random = new System.Random();

    public float destroyTime = 2;
    void Start()
    {
        transform.Find("Armature").Find("Hips").GetComponent<Rigidbody>().AddForce((random.Next(-1,1)*50), 100f, 0, ForceMode.Impulse);
        Destroy(this.gameObject, destroyTime);
    }


    private void OnTriggerEnter(Collider other)
    { 
        if(other.tag == "Obstacle")
        {
            Destroy(this.gameObject);
        }
    }
}

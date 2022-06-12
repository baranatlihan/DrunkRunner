using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectEffectScript : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && GameManager.staticPlayer.transform.localScale.x < 2)
        {
            GameManager.staticPlayer.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
        }
        

        if (other.gameObject.CompareTag("Player") && this.CompareTag("Harmfull") && GameManager.staticPlayer.transform.localScale.x > 0.25)
        {
            GameManager.staticPlayer.transform.localScale -= new Vector3(0.02f, 0.02f, 0.02f);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;
    private Joystick joystick;
    public float speed;


    private void Awake()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
    }

    void Update()
    {


        if (joystick.Horizontal >= 0.2f && transform.position.x < 3) 
        {
            anim.enabled = true;
            transform.position += transform.right * Time.deltaTime * speed * (Mathf.Abs(joystick.Horizontal));
        }
        else if (joystick.Horizontal <= -0.2f && transform.position.x > -2) 
        {
            anim.enabled = true;
            transform.position -= transform.right * Time.deltaTime * speed * (Mathf.Abs(joystick.Horizontal));
        }
        else
        {
            anim.enabled = true;
        }
    }



}

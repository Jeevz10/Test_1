using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Speed = 1f;
    public float torque = 5f;
    public float amount = 50f;
	// Use this for initialization
	void Start () {
		
	}



    // Update is called once per frame
    
	void Update () {

        Vector2 dir = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            dir += new Vector2(1, 1);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            dir += Vector2.down;
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            dir += Vector2.right;
        }
        dir = dir.normalized;

        Vector2 translateDist = dir * Speed * Time.deltaTime;
        transform.Translate(translateDist);
	}


  
}

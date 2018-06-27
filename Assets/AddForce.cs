using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour {
    Rigidbody2D rb;
    public float force = 1500f;

	// Use this for initialization
	void Start () {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
        float h = Input.GetAxis("Horizontal") * force * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * force * Time.deltaTime;

        /*
        rb.AddForce(new Vector2(h,0));
        rb.AddForce(new Vector2(0,v));
        */

        rb.AddTorque(v);
    }
}

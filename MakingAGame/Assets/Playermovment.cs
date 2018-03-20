using UnityEngine;

public class Playermovment : MonoBehaviour {

    public Rigidbody rb;

    public float ForwardForce = 2000f;
    public float SideWaysForcw = 500f; 
	// Update is called once per frame
	void FixedUpdate () {

        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);  // Player movment and add forward force to inspector

        if (Input.GetKey("d"))
        {

            rb.AddForce(SideWaysForcw * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {

            rb.AddForce(-SideWaysForcw * Time.deltaTime, 0, 0);
        }
    }
}

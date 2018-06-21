using UnityEngine;

public class Movement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 1000f; // By making it public, it becomes an editible option in Unity.
    public float sidewaysForce = 500f; // Used for lateral movement.  Also, notice the f at the end, this is specific to Unity for float numbers.  It will complain if left out, so good idea to use these always for floats.
    
	
	// Update is called once per frame
	void FixedUpdate () { // FixedUpdate is better for physics based functions.

        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);            
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce* Time.deltaTime, 0, 0);
        }
    }
}

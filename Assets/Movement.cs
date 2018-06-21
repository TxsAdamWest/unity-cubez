using UnityEngine;

public class Movement : MonoBehaviour {

    public Rigidbody rb;

	
	// Update is called once per frame
	void FixedUpdate () { // FixedUpdate is better for physics based functions.

        rb.AddForce(0, 0, 2000 * Time.deltaTime);

	}
}

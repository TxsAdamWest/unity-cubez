using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset; // Stores 3 floats.  Perfect for 3-d positioning.
	
	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset;
	}
}

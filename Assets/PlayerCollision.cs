using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement movement;

    void OnCollisionEnter(Collision collisionInfo) // This built in Unity function will run anytime a rigid body object collides with another.
    {
        if (collisionInfo.collider.tag == "Obstacle") // Checking for tags is much more efficient than checking for names of every object in a scene. 
        {
            movement.enabled = false;
        }
    }
}

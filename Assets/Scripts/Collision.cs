using UnityEngine;

public class Collision : MonoBehaviour {

    // player movement
    public Movement movement;
    
    // detect collision
    void OnCollisionEnter(UnityEngine.Collision collisionInfo) {

        // if hit an obstacle
        if (collisionInfo.gameObject.tag == "Obstacle") {
            // knock them off the course
            movement.knockOff();
        }
       
    }
}

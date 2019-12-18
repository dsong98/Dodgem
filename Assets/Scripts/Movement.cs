using UnityEngine;

public class Movement : MonoBehaviour {

	// the Rigidbody component of the cube
	public Rigidbody rb;

    // constants for movement
    public float forwardForce = 1500f;
    public float sidewaysForce = 80f;
    public float knockOffForce = 2000f;

    // get player location
    public Transform playerLoc;

    // how far they must fall to be counted as dead
    public float deathLoc = -3f;

    // Start is called before the first frame update
    void Start() {
        Debug.Log("Game Started!");
    }

    // *changed to fixedUpdate()
    // Update is called once per frame
    void FixedUpdate() {
        // check if fell off course
        if (playerLoc.position.y < deathLoc) {
            FindObjectOfType<GameManager>().EndGame();
        }

        // go forward, always on
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // go left
        if (Input.GetKey("a") || Input.GetKey("left")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        // go right
        if (Input.GetKey("d") || Input.GetKey("right")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }

    // knock the player off the course
    public void knockOff() {
            // kick them to the left
            if (playerLoc.position.x < 0) {
                rb.AddForce(-knockOffForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            // kick them to the right
            else {
                rb.AddForce(knockOffForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
    }
}

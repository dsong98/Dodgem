using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    // get the Transform information of the player
    public Transform player;

    // offset for how far behind camera is
    public Vector3 offset = new Vector3(0f, 1f, -3f);

    // Update is called once per frame
    void Update() {
        // get player position
         Vector3 playerPos = player.position;

        // move camera behind player
        transform.position = playerPos + offset;
    }
}

using UnityEngine;
using UnityEngine.UI;
    
public class Score : MonoBehaviour {

    public Transform playerLoc;

    public Text scoreText;

    void Update() {
        scoreText.text = playerLoc.position.z.ToString("0");
    }
    
}
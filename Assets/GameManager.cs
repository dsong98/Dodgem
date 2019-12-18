using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    // when level is finished
    public GameObject completeLevelUI;

    // if game has ended or not
    bool gameEnded = false;

    void Start() {
        completeLevelUI.SetActive(false);
    }

    // game over
    public void EndGame() {
        if (gameEnded == false) {
            gameEnded = true;
            Debug.Log("Game Over!");

            // restart the game
            restart();
        }   
    }

    public void levelComplete() {
        Debug.Log("Level Completed!");
        completeLevelUI.SetActive(true);
    }

    void restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

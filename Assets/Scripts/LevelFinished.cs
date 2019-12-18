using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinished : MonoBehaviour
{
    // delay for a little bit and then load the next level
    void Start() {
        Invoke("loadNextLevel", 1.5f);
    }

    // load the next level
    void loadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

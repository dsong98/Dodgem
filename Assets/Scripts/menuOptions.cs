using UnityEngine;
using UnityEngine.SceneManagement;

public class menuOptions : MonoBehaviour
{
    
    // play the game
    public void playGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

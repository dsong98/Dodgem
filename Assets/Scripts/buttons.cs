using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{

    // return to the menu
    public void returnToMenu() {
        SceneManager.LoadScene(0);
    }

    // quit the game
    public void quitGame() {
        Application.Quit();
    }
}

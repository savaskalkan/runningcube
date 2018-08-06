using UnityEngine.SceneManagement;
using UnityEngine;

public class start : MonoBehaviour {

    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}

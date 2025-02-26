using UnityEngine;
using UnityEngine.SceneManagement;

// DONE
public class GameManager : MonoBehaviour
{
    public static GameManager GameManagerInstance;
    [SerializeField] private GameObject _gameOverCanvas;

    // Start is called before the first frame update
    void Awake()
    {
        if (GameManagerInstance == null) 
        {
            GameManagerInstance = null;
        }

        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        // activate _gameOverCanvas
        _gameOverCanvas.SetActive(true);

        // set timeScale back to 0 to indicate that the game is over
        Time.timeScale = 0f;
    }

    // assign this to PlayButton
    // note: when you want a button to call a method, that method must be public!
    public void RestartGame()
    {
        // use SceneManager to reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

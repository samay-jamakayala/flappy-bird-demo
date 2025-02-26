using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {

    }

    private void GameOver()
    {

    }
}

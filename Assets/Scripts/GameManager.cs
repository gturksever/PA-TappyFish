using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static Vector2 bottomLeft;
    public static bool gameOver;
    public GameObject gameOverPanel;
    public static bool gameStarted;
    public GameObject getReadyImg;
    public GameObject score;
    public static int gameScore=9999;
    private void Awake()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        gameOver = false;
    }

    void Start()
    {

        gameStarted = false;
    }

    public  void GameOver()
    {
        gameOver = true;
        gameScore = score.GetComponent<Score>().GetsScore();
        gameOverPanel.SetActive(true);
        score.SetActive(false);
    }

    public void RestartBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameHasStarted()
    {
        gameStarted = true;
        getReadyImg.SetActive(false);
    }
    
    void Update()
    {
        
    }
}

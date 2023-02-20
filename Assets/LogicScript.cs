using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore, highScore;
    public Text scoreText;
    public Text highScoreText;
    public GameObject gameOverScreen;
    public AudioSource source;
    // create singleton so can access from other scripts

    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
            highScoreText.text = highScore.ToString();
        }

    }

    // [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if (!gameOverScreen.activeSelf)
        {
            source.Play();
            playerScore = playerScore + scoreToAdd;
            scoreText.text = playerScore.ToString();
        }

    }

    public void updateHighScore()
    {
        if(playerScore > highScore)
        {
            highScore = playerScore;
            highScoreText.text = highScore.ToString();

            // Save into memory
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }

    public void restartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        updateHighScore();
        gameOverScreen.SetActive(true);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}

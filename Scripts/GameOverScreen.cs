using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text scoreText;


    public void Setup(int score)
    {
        gameObject.SetActive(true);
        scoreText.text = score.ToString() + " pts";
    }

    public void ReplayButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}

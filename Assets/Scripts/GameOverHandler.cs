using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text gameOverText;
    [SerializeField] private ScoreSystem scoreSystem;
    [SerializeField] private GameObject gameOverDisplay;
    [SerializeField] private AsteroidSpawner asteroidSpawner;
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private Button continueButton;

    public void EndGame()
    {
        asteroidSpawner.enabled = false;

        gameOverText.text = $"Your Score: {scoreSystem.GetScoreText()}";
        scoreSystem.PauseScore(true);
        gameOverDisplay.gameObject.SetActive(true);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }

    public void ContinueButton()
    {
        AdManager.Instance.ShowAd(this);
        continueButton.interactable = false;
    }

    public void Continue()
    {
        scoreSystem.PauseScore(false);
        playerHealth.Reset();
        asteroidSpawner.enabled = true;
        gameOverDisplay.gameObject.SetActive(false);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}

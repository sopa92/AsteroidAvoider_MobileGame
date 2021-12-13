using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    [SerializeField] private float scoreMultiplier;

    private float score;

    private bool isPaused;
    // Update is called once per frame
    void Update()
    {
        if (isPaused)
            return;

        score += Time.deltaTime * scoreMultiplier;

        scoreText.text = Mathf.FloorToInt(score).ToString();
    }

    public string GetScoreText()
    {
        return scoreText.text;
    }

    public void PauseScore(bool toBePaused)
    {
        if(toBePaused)
            ResetText();

        isPaused = toBePaused;
    }

    public void ResetText()
    {
        scoreText.text = String.Empty;
    }
}

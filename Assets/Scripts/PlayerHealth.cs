using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameOverHandler gameOverHandler;
    public void Crash()
    {
        gameObject.SetActive(false);

        gameOverHandler.EndGame();
    }

    public void Reset()
    {
        gameObject.SetActive(true);
        gameObject.GetComponent<PlayerMovement>().Reset();
    }
}

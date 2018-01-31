using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameStats : MonoBehaviour {

    public static GameStats instance = null;
    public Text scoreBoard;
    public Text healthBoard;
    public GameObject restartPanel;
    static public int playerScore = 0;
    static public int playerHealth = 3;

    public MonoBehaviour[] scriptsToTurnOff;
    // Use this for initialization
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void UpdateScore()
    {
        scoreBoard.text = "Score " + playerScore;
    }

    public void UpdateHealth()
    {
        healthBoard.text = "Lives " + playerHealth;
    }

    public static void SetScore(int score)
    {
        playerScore = score;
        instance.UpdateScore();
    }

    public static void IncrementScore(int points)
    {
        playerScore += points;
        print(playerScore);
        instance.UpdateScore();
    }

    public static void SetHealth(int health)
    {
        playerHealth = health;
        instance.UpdateHealth();
    }

    public static void DecrementHealth(int healthLost)
    {
        playerHealth -= healthLost;
        instance.UpdateHealth();
        if (playerHealth <= 0)
        {
            GameOver();
        }
    }


    public static void GameOver()
    {
        print("not implemented, player should die");
        instance.restartPanel.SetActive(true);
        for(int i = 0; i < instance.scriptsToTurnOff.Length; i++)
        {
            instance.scriptsToTurnOff[i].enabled = false;
        }

    }
}

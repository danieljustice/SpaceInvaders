using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStats : MonoBehaviour {

    public static GameStats instance = null;

    static public int playerScore = 0;
    static public int playerHealth = 3;
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

    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public static void SetScore(int score)
    {
        playerScore = score;
    }

    public static void IncrementScore(int points)
    {
        playerScore += points;
        print(playerScore);
    }

    public static void SetHealth(int health)
    {
        playerHealth = health;
    }

    public static void DecrementHealth(int healthLost)
    {
        playerHealth -= healthLost;
        if(playerHealth <= 0)
        {
            //game over
            //Death function
            GameOver();
        }
    }


    public static void GameOver()
    {
        print("not implemented, player should die");
    }
}

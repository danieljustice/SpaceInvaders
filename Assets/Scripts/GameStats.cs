using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStats : MonoBehaviour {

    public static GameStats instance = null;

    public int playerScore = 0;
    public int playerHealth = 3;
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

    public void SetScore(int score)
    {
        playerScore = score;
    }

    public void IncrementScore(int points)
    {
        playerScore += points;
    }

    public void SetHealth(int health)
    {
        playerHealth = health;
    }

    public void DecrementHealth(int healthLost)
    {
        playerHealth--;
        if(playerHealth <= 0)
        {
            //game over
            //Death function
            PlayerDeath();
        }
    }


   public void PlayerDeath()
    {
        print("not implemented, player should die");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour {
    public EnemyPoints enemyPoints;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Bullet")
        {
            print(transform.tag);
            print(collision.transform.tag);
            GameStats.IncrementScore(enemyPoints.points);
            gameObject.SetActive(false);    
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour {
    public EnemyPoints enemyPoints;
    public AudioSource audioSource;
    public AudioClip deathClip;

    private void Start()
    {
        audioSource = GetComponentInParent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Bullet")
        {
            GameStats.IncrementScore(enemyPoints.points);
            StartCoroutine(PlayAudio(deathClip));
            gameObject.SetActive(false);            
        }
    }


    IEnumerator PlayAudio(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
    }
}

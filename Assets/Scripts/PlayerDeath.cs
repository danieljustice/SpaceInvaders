using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {

    public AudioSource audioSource;
    public AudioClip clip;

    private void OnCollisionEnter(Collision collision)
    {
        string otherTag = collision.transform.tag;
        print(otherTag);
        if(otherTag == "EnemyBullet" || otherTag == "Alien")
        {
            GameStats.DecrementHealth(1);
            StartCoroutine(PlayAudio(clip));
        }
    }

    IEnumerator PlayAudio(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
    }
}

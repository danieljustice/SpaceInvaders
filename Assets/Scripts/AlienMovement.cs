using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMovement : MonoBehaviour {

    public GameObject sprite1;
    public GameObject sprite2;
    public ChanceToShoot shotChance;
    public GameObject shot;

    public GridMovement gridMovement;
	// Use this for initialization
	void Start () {
        sprite1.SetActive(true);
        sprite2.SetActive(!sprite1.activeSelf);
        gridMovement = GameObject.FindObjectOfType<GridMovement>();
    }
	

    public void ChangeSprite()
    {
        sprite1.SetActive(!sprite1.activeSelf);
        sprite2.SetActive(!sprite2.activeSelf);
        AttemptToFire();
    }

    public void AttemptToFire()
    {
        float roll = Random.Range(0f, 1f);
        if(roll < shotChance.shotPercent)
        {
            Instantiate(shot, transform.position, Quaternion.identity);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("collided");
        if(collision.transform.tag == "Boundary")
        {
            gridMovement.ChangeDirection();
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}

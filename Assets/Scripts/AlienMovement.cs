using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMovement : MonoBehaviour {

    public GameObject sprite1;
    public GameObject sprite2;

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

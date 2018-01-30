using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 10f;

    private CharacterController controller;
    private Vector3 movement = Vector3.zero;

    // Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        movement = transform.TransformDirection(movement);

        movement *= speed;
        controller.Move(movement * Time.deltaTime);
	}
}

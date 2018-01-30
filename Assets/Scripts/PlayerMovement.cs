using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 10f;

    private CharacterController controller;
    private Vector3 movement = Vector3.zero;

    public GameObject bullet;
    public Vector3 spawnOffset = new Vector3(0f, 0f, 0f);
    // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController>();
        bullet.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        movement = transform.TransformDirection(movement);

        movement *= speed;
        controller.Move(movement * Time.deltaTime);

        if (Input.GetKeyDown("space"))
        {
            Fire();
        }
    }

    void Fire()
    {
       
        print(bullet.activeSelf);
        if (!bullet.activeSelf)
        {
            Vector3 spawnPoint = spawnOffset + transform.position;
            //bullet.transform =
            bullet.transform.localPosition = spawnPoint;
            bullet.SetActive(true);
        }
    }
}

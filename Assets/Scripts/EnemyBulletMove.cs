using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMove : MonoBehaviour {
    public float speed = 10f;

    private Vector3 movement = Vector3.zero;
    // Use this for initialization
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.MovePosition(transform.position + speed * transform.up * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //gameObject.SetActive(false);
        Destroy(gameObject);
    }
}

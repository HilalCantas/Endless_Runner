using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private Rigidbody rb;
    public float charSpeed = 4f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * charSpeed;

        transform.position += transform.forward * Time.deltaTime * charSpeed;

        Vector3 vel = rb.velocity;
        vel.x = h;
        rb.velocity = vel;

        
    }
}

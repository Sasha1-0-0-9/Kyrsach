using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SphereScript : MonoBehaviour
{ 
    protected float speed = 5f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Time.timeScale = 1f;
    }

    void Update()
    {
            Vector3 movement = new Vector3(UnityEngine.Random.Range(-20, 20) * speed, 0.0f, UnityEngine.Random.Range(-20, 20) * speed);
            rb.AddForce(movement);      
    }

}

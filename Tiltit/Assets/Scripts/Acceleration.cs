using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Acceleration : MonoBehaviour
{
    public bool isFlat = true;
    private Rigidbody rb;
    float moveSpeed = 7f;
    

    void Start()
    {   
        rb = GetComponent<Rigidbody>();
    } 

    void Update()
    {
            Vector3 tilt = Input.acceleration * moveSpeed;
            if (isFlat)
            {
                tilt = Quaternion.Euler(125, 0, 0) * tilt; // makes the game playable from holding position
            }
            rb.AddForce(tilt);
            Debug.DrawRay(transform.position + Vector3.up, tilt, Color.green);
    }


    
}

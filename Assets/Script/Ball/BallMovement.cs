using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody ballBody;
    public AudioClip audioClip;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer == 8) {
            Player player = other.GetComponent<Player>();
            int magnitude = 1000;
            var force = transform.position - other.transform.position;
            if (Input.GetKey(KeyCode.F)) {
                audioSource.Play();
                magnitude = magnitude * 2;
              }
            force.Normalize();
            ballBody.AddForce(force * magnitude);
        }

        
    }
}

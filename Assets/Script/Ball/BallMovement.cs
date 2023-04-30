using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public int forceMultiplier = 5;
    public int startSpeed = 350;
    public Rigidbody ballBody;
    public AudioClip audioClip;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.layer == 8) {
            int magnitude = startSpeed;
            var force = transform.position - other.transform.position;

            if (Input.GetKey(KeyCode.Space)) {
                audioSource.Play();
                magnitude = magnitude * forceMultiplier;
              }
            force.Normalize();
            ballBody.AddForce(force * magnitude);
        }
    }


}

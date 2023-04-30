using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Rigidbody ballBody;

    private void OnCollisionEnter(Collision other) {
        Debug.Log("Ball hit the wall");
        if (other.gameObject.layer == 6) {
            
            Debug.Log("Ball hit the wall and is layer 6");
            int magnitude = 10000;
            var force = transform.position - other.transform.position;
            force.Normalize();
            ballBody.AddForce(force * magnitude);
        }

        

    }
}

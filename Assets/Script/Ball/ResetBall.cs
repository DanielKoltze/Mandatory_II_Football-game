using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour
{
    private Vector3 spawnPoint;
    public Transform ballTrans;
    public Rigidbody ballRigidBody;
    
    void Start()
    {
        spawnPoint = ballTrans.position;
    }


    public void resetBall()
    {

        ballTrans.position = spawnPoint;
        ballRigidBody.velocity = Vector3.zero;

    }
}

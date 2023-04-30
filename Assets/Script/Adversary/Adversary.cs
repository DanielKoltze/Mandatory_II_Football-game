using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Adversary : MonoBehaviour
{
    public GameObject ball;
    public GameObject player;
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == ball)
        {
            Player playerModel = player.GetComponent<Player>();
            playerModel?.Die();
            ResetBall ballModel = ball.GetComponent<ResetBall>();
            ballModel.resetBall();
            
        }
    }
}
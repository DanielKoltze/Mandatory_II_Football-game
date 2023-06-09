using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectGoal : MonoBehaviour
{
    public GameObject player;
    public AudioSource onGoal;
 
private void OnTriggerEnter(Collider other) {
    if (other.gameObject.layer == 7) {
        onGoal.Play();
        ResetBall ball = other.GetComponent<ResetBall>();
        ball.resetBall();
        Player playerScript = player.GetComponent<Player>();
        playerScript.Die();

    }
} 
}

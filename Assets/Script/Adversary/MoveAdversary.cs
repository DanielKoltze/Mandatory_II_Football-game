using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAdversary : MonoBehaviour
{
    public float speed = 5f;
    public float distance = 10f;
    public Transform transform;

    private Vector3 startPosition; 
    private bool movingRight = true; 

    void Start()
    {
        startPosition = transform.position; 
    }

    void Update()
    {
        if (movingRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime; 
        }
        else
        {
            transform.position += Vector3.left * speed * Time.deltaTime; 
        }

        if (transform.position.x >= startPosition.x + distance)
        {
            movingRight = false;
        }
        else if (transform.position.x <= startPosition.x - distance)
        {
            movingRight = true; 
        }
    }

}

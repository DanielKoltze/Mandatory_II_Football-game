using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController characterController;
    public float moveSpeed = 3.0f;
    private Vector3 movement = Vector3.zero;
    public Transform transformer;

    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            movement = -transformer.forward * moveSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            movement = transformer.forward * moveSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            movement = transformer.right * moveSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            movement = -transformer.right * moveSpeed;
        }
        
        characterController.Move(movement * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform ballTransform;

    public Quaternion cameraRotationOffset;
    public Vector3 cameraPositionOffset;
    // Start is called before the first frame update
    void Start()
    {
        cameraPositionOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ballTransform.position + cameraPositionOffset;

    }
}

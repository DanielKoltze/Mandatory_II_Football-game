using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject secondaryCamera;
    // Start is called before the first frame update
    void Start()
    {
        secondaryCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) {
            if(mainCamera.activeInHierarchy == true) {
                mainCamera.SetActive(false);
                secondaryCamera.SetActive(true);
            }
            else {
                secondaryCamera.SetActive(false);
                mainCamera.SetActive(true);
            }
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseLook : MonoBehaviour
{
    public float mouseSensivity = 100f;
    public Transform playerBody;

   
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked; 
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime; 
        playerBody.Rotate(Vector3.up * mouseX);
    }
}

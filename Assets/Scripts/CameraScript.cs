using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private float mouseSensitivity = 3f;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void LateUpdate()
    {
        float mx = Input.GetAxis("Mouse X");   // зрушення миші по горизонталі
        this.transform.RotateAround(Vector3.zero, Vector3.up, mx * mouseSensitivity);

        float my = -Input.GetAxis("Mouse Y") * mouseSensitivity;
        if(this.transform.eulerAngles.x + my > 35
            && this.transform.eulerAngles.x + my <= 85)
        {
            this.transform.RotateAround(Vector3.zero, this.transform.right, my);
        }
        
    }
}

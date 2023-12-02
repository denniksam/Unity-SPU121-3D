using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    private Rigidbody body;
    // [SerializeField]
    private float forceFactor = 300f;

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 f = Camera.main.transform.forward;
        f.y = 0;
        f = f.normalized;

        Vector3 moveDirection = 
            Camera.main.transform.right * h + f * v;
            

        body.AddForce(forceFactor * Time.deltaTime * moveDirection);
    }
}

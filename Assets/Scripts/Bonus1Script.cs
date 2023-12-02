using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus1Script : MonoBehaviour
{
    private float centerPosition;
    private float velocity = -.3f;

    void Start()
    {
        centerPosition = this.transform.position.y;
    }

    void Update()
    {
        if (GameState.isCheckPoint1)
        {
            transform.Translate(Time.deltaTime * velocity * Vector3.up);
            if (transform.position.y > centerPosition
             || transform.position.y < -centerPosition)
            {
                velocity = -velocity;
            }
        }
    }
}

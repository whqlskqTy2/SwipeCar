using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float moveSpeed = 0f;
    bool isMove = false;
   
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isMove.Equals(false))
        {
            moveSpeed = 0.2f;
            isMove = true;
        }

        transform.Translate(moveSpeed, 0, 0);
        moveSpeed *= 0.97f;
        if (moveSpeed < 0.01f)
        {
            moveSpeed = 0;
        }
    }
}

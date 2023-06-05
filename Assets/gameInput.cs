using System;
using UnityEngine;


public class gameInput : MonoBehaviour
{


    [SerializeField] private float moveSpeed = 7f;
    public Vector2 getmovementV()
    {
       
        Vector2 inputVector = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.y = +1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            inputVector.y = -1;
        }

        if (Input.GetKey(KeyCode.W))
        {
            inputVector.x = -1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            inputVector.x = +1;
        }
        inputVector = inputVector.normalized;
        return inputVector;
        /*
               float movedistince = moveSpeed * Time.deltaTime;
               float playerSize = .7f;
               float playerH = .2f;
               Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
               bool canMove = !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerH, playerSize, moveDir, movedistince);
               if (canMove)
               {
                   transform.position += moveDir * movedistince;
               }
               float rotatespeed = 10f;
               transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * rotatespeed);
               
        Debug.Log(Time.deltaTime);
        */



    }

    
}
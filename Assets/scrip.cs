using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private gameInput gameInput;
    [SerializeField] private clearcounter clearcounter;
    private bool iswalking;
    private Vector3 lastinteractDir;

// Update is called once per frame 
private void Update()
    {
        handleinter();
        handleMovement();
       
       
      
    }



    private void handleinter()
    {
        Vector2 inputVector = gameInput.getmovementV();
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
         if (moveDir != Vector3.zero)
        { lastinteractDir = moveDir; }
        float interactDistance = 2f;
        if (Physics.Raycast(transform.position, lastinteractDir, out RaycastHit raycastHit, interactDistance))
        {
            if (raycastHit.transform.TryGetComponent(out clearcounter clearcoumter))
            {
                clearcounter.Interact();
            }    
                
        }
        else
        {
            Debug.Log("- ");
        }




    }

    private void handleMovement()
    {
        Vector2 inputVector = gameInput.getmovementV();
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
      

      

        float movedistince = moveSpeed * Time.deltaTime;
        float playerSize = .7f;
        float playerH = .2f;
       
        bool canMove = !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerH, playerSize, moveDir, movedistince);
        if (canMove)
        {

        
            transform.position += moveDir * movedistince;
          
        }
        float rotatespeed = 10f;
        transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * rotatespeed);
        Debug.Log(Time.deltaTime);
        
       
    }

} 

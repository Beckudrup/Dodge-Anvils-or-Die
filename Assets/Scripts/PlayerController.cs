using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private int playerSpeed = 3;
    //private int jumpHeight = 5;

    public Transform orientation;

    Rigidbody playerBody;
    

    private PlayerActions playerActions;

    private void Awake()
    {
        playerActions = new PlayerActions();
        playerBody = GetComponent<Rigidbody>();
        playerBody.freezeRotation = true;
    }

    private void OnEnable()
    {
        //playerActions.Enable();
    }
    private void OnDisable()
    {
        //playerActions.Disable();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMove();

    }

    void PlayerMove()
    {
        Vector3 playerMove = playerActions.Movement.Move.ReadValue<Vector3>();
        Debug.Log(playerMove);
        playerBody.velocity = transform.TransformDirection(playerMove).normalized*playerSpeed;
        

        /*if (playerActions.Movement.Jump.triggered)
        {
            Debug.Log("Hop");
            //Hop
        }
        */

    }
}

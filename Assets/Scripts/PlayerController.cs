using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{


    private PlayerActions playerActions;

    private void Awake()
    {
        playerActions = new PlayerActions();
    }

    private void OnEnable()
    {
        playerActions.Enable();
    }
    private void OnDisable()
    {
        playerActions.Disable();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerMove = playerActions.Movement.Move.ReadValue<Vector3>();
        Debug.Log(playerMove); 

        if (playerActions.Movement.Jump.triggered)
        {
            Debug.Log("Hop");
            //Hop
        }
    }
}

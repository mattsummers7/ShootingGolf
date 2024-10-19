using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InputManager : MonoBehaviour
{
    public MovementControllerCharCon movementController;
    public Vector2 movementInput = Vector2.zero;
    


    private void Update()
    {
        //Debug.Log(movementInput);
        movementController.HandleJump();
    }
    public void OnMove(InputAction.CallbackContext ctx)
    {
        movementInput = ctx.ReadValue<Vector2>();
       
    }

    public void OnJump(InputAction.CallbackContext ctx)
    {
        if(ctx.action.triggered && movementController.characterController.isGrounded)
        {
            movementController.jumpPressed = true;
        }
    }
}

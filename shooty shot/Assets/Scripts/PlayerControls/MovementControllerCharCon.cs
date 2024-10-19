using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControllerCharCon : MonoBehaviour
{
    public InputManager inputManager; 
    public CharacterController characterController;

    private Vector3 characterMovement;

    float gravity = -0.3f;

    public float gravityMultiplier = 1f;
    public float speedMultiplier = 1f;
    public float jumpForce;
    public bool jumpPressed;
    void Update()
    {
        gravity -= gravityMultiplier * Time.deltaTime;

        if(gravity <= 0 && characterController.isGrounded)
        {
            gravity = -.1f;
        }

        if (characterController.isGrounded == true)
        {
            jumpPressed = false;
            
        }



        characterMovement = new Vector3(inputManager.movementInput.x * speedMultiplier * Time.deltaTime, gravity, inputManager.movementInput.y * speedMultiplier * Time.deltaTime);

        characterController.Move(characterMovement);
    }

    private void Gravity()
    {
        if(characterController.isGrounded != true)
        {
            
        }
    }

    public void HandleJump()
    {
        if(characterController.isGrounded && jumpPressed)
        {
            gravity += jumpForce;
        }
    }
}

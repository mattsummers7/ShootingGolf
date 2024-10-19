using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public InputManager inputManager;
    public Rigidbody player;
    public float moveSpeed = 5;
    private float maxVelocity = 5;
    private Vector3 movementDirection;

    

    void Update()
    {
        var v = player.velocity;

        if (inputManager.movementInput.x != 0 || inputManager.movementInput.y != 0)
        {
            movementDirection = new Vector3(inputManager.movementInput.x, 0, inputManager.movementInput.y);
            player.AddForce(movementDirection.normalized * moveSpeed, ForceMode.Force);
            if(player.velocity.sqrMagnitude > 25)
            {
                player.velocity = v.normalized * maxVelocity;
            }
        }
        else
        {
            movementDirection = Vector3.zero;
            player.velocity = Vector3.zero;
        }

        Debug.Log(player.velocity.sqrMagnitude);
    }
}

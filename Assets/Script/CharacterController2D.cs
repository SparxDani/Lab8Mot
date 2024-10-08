using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController2D : MonoBehaviour
{
    private Rigidbody2D myRBD2;
    [SerializeField] private float velocity;
    private Vector2 moveDirection;


    private void Start()
    {
        myRBD2 = GetComponent<Rigidbody2D>();

    }
    private void Update()
    {
        myRBD2.velocity = moveDirection * velocity;

    }
    public void OnMovement(InputAction.CallbackContext context)
    {
        moveDirection = context.ReadValue<Vector2>();

    }

}

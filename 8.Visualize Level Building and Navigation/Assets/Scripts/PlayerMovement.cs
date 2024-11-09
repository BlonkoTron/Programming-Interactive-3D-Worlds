using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    [SerializeField]private float playerSpeed = 2.0f;
    

    private Vector3 move;
    private Vector3 Movement;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {

        Vector3 direction = Quaternion.AngleAxis(transform.rotation.eulerAngles.y, Vector3.up) * move;

        Movement = direction.normalized * playerSpeed;

        if (Movement != Vector3.zero )
        {
            controller.Move(Movement * Time.deltaTime * playerSpeed);
        }
        
    }

    void OnMove(InputValue input)
    {
        move = input.Get<Vector3>();
    }
}

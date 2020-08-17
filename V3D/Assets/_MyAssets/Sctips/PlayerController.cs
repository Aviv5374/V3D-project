using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    float _gravity = 9.81f;

    PlayerActionInputs inputActions;
    CharacterController controller;
    ThirdPersonController thirdPersonController;

    #region Initialization

    void Awake()
    {
        inputActions = new PlayerActionInputs();
        controller = GetComponent<CharacterController>();
        thirdPersonController = GetComponent<ThirdPersonController>();
	}

    void OnEnable()
    {
        inputActions.Enable();
    }

    void Start()
    {
        
    }
     
    #endregion

    #region Updating	 

    void Update()
    {
        Move();
        CalculateMovement();        
    }

    #endregion

    void Move()
    {
        float horizontalAxis = inputActions.Move.Horizontal.ReadValue<float>();
        float verticalAxis = inputActions.Move.Vertical.ReadValue<float>();
        Vector3 direction = new Vector3(horizontalAxis, 0, verticalAxis).normalized;
        thirdPersonController.ThirdPersonMovment(direction);
    }

    void CalculateMovement()
    {
        float horizontalAxis = inputActions.Move.Horizontal.ReadValue<float>();
        float verticalAxis = inputActions.Move.Vertical.ReadValue<float>();
        //Debug.Log("horizontal Axis=" + horizontalAxis);
        //Debug.Log("vertical Axis=" + verticalAxis);
        Vector3 direction = new Vector3(horizontalAxis, 0, verticalAxis).normalized;
        Debug.Log("direction.magnitude = " + direction.magnitude);
        //Vector3 velocity = direction * speed;
        //velocity.y -= _gravity;
        //velocity = transform.TransformDirection(velocity);
        //controller.Move(velocity * Time.deltaTime);
    }

    void OnDisable()
    {
        inputActions.Disable();
    }

}
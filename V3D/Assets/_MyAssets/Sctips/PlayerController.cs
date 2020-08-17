using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    PlayerActionInputs inputActions;

    #region Initialization

	void Awake()
    {
        inputActions = new PlayerActionInputs();
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
        float horizontal = inputActions.Move.Horizontal.ReadValue<float>();
        Debug.Log(horizontal);
        //Vector3 move = new Vector3(0, 0, 0);
        //transform.Translate(move * speed * Time.deltaTime);
    }

    #endregion

    void OnDisable()
    {
        inputActions.Disable();
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;
    ThirdPersonController thirdPersonController;

    #region Initialization

    void Awake()
    {        
        controller = GetComponent<CharacterController>();
        thirdPersonController = GetComponent<ThirdPersonController>();
	}
    

    void Start()
    {
        
    }
     
    #endregion

    #region Updating	 

    void Update()
    {
        Move();          
    }

    #endregion

    void Move()
    {        
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float verticalAxis = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontalAxis, 0, verticalAxis).normalized;
        thirdPersonController.ThirdPersonMovment(direction);
    }

        

}
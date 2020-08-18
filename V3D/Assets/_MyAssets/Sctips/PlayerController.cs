using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    

    ThirdPersonController thirdPersonController;
    PlayerAnimatorHandler playerAnimator;

    #region Initialization

    void Awake()
    {                
        thirdPersonController = GetComponent<ThirdPersonController>();
        playerAnimator = GetComponent<PlayerAnimatorHandler>();

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
        playerAnimator.SetRruning(direction.magnitude >= 0.1f);
        thirdPersonController.ThirdPersonMovment(direction);
    }

        

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Camera mainCamera = null;

    ThirdPersonController thirdPersonController;
    PlayerAnimatorHandler playerAnimator;
    Shooter shooter;

    #region Initialization

    void Awake()
    {
        if (!mainCamera)
        {
            mainCamera = Camera.main;
        }

        thirdPersonController = GetComponent<ThirdPersonController>();
        playerAnimator = GetComponent<PlayerAnimatorHandler>();
        shooter = GetComponent<Shooter>();

    }
    
    void Start()
    {
        
    }
     
    #endregion

    #region Updating	 

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {            
            shooter.Shoot(mainCamera);
        }
        //else
        //{
        //    shooter.SetTarget(mainCamera);
        //}

        Move();          
    }

    #endregion

    void Move()
    {        
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float verticalAxis = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontalAxis, 0, verticalAxis).normalized;
        playerAnimator.SetRruning(direction.magnitude >= 0.1f);
        thirdPersonController.ThirdPersonMovment(direction, mainCamera.transform);
    }

        

}
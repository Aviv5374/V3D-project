using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class ThirdPersonController : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float turnSmoothTime = 0.1f;    

    CharacterController controller;

    #region Initialization

    void Awake()
	{        
        controller = GetComponent<CharacterController>();
    }
			
    void Start()
    {
        
    }
     
    #endregion

    #region Updating	 

    void Update()
    {
        
    }

    #endregion

    public void ThirdPersonMovment(Vector3 direction, Transform mainCamera)
    {
        if (direction.magnitude >= 0.1f)
        {
            float turnSmoothVelocity = 0;
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + mainCamera.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0, angle, 0);

            Vector3 MoveDir = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;
            controller.Move(MoveDir.normalized * speed * Time.deltaTime);
        }
    }

}
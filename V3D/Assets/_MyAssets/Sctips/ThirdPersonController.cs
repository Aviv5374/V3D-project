using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class ThirdPersonController : MonoBehaviour
{
    [SerializeField] float speed = 5f;

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

    public void ThirdPersonMovment(Vector3 direction)
    {
        if (direction.magnitude >= 0.1f)
        {
            
            Vector3 velocity = direction * speed;
            //velocity.y -= _gravity;
            //velocity = transform.TransformDirection(velocity);
            controller.Move(velocity * Time.deltaTime);
        }
    }

}
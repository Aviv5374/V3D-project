using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Camera mainCamera = null;
    [SerializeField] float zoom = 2f;
    [SerializeField] float mouseSensitivity = 4f;

    bool isZoomed = false;


    ThirdPersonController thirdPersonController;
    PlayerAnimatorHandler playerAnimator;
    Shooter shooter;
    public bool IsZoomed { get { return isZoomed; } }

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
        ProcessZoom();
        if (IsZoomed)
        {
            shooter.SetGunRotation(mainCamera.transform.rotation);
            if (Input.GetButtonDown("Fire1"))
            {
                shooter.Shoot(mainCamera);
            }
        }

        Move();
    }

    #endregion

    void ProcessZoom()
    {
        if (Input.GetMouseButton(1))
        {
            isZoomed = true;
            mainCamera.fieldOfView /= zoom;           
            //fpsController.mouseLook.XSensitivity /= mouseSensitivity;
            //fpsController.mouseLook.YSensitivity /= mouseSensitivity;

            //TODO: Fine a way to replace the code above with this method
            //SetZoomValues(bool isZoomed, Operator operator);
        }

        if (Input.GetMouseButtonUp(1))
        {
            isZoomed = false;
            mainCamera.fieldOfView *= zoom;
            //fpsController.mouseLook.XSensitivity *= mouseSensitivity;
            //fpsController.mouseLook.YSensitivity *= mouseSensitivity;

            //TODO: Fine a way to replace the code above with this method
            //SetZoomValues(bool isZoomed, Operator operator);
        }
    }

    void Move()
    {
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float verticalAxis = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontalAxis, 0, verticalAxis).normalized;
        playerAnimator.SetRruning(direction.magnitude >= 0.1f);
        thirdPersonController.ThirdPersonMovment(direction, mainCamera.transform);
    }



}
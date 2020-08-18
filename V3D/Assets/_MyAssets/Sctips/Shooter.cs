using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    const string BULLETS_PARENT_NAME = "Bullets";
    
    [SerializeField] Bullet bullet;
    [SerializeField] Transform gun;    
    [SerializeField] float gunZAxis = 2f;

    GameObject projectilesParent;

    #region Initialization

    void Awake()
	{
		
	}
			
    void Start()
    {
        CreateBulletsParent();
    }
     
    #endregion

    #region Updating	 

    void Update()
    {
        
    }

    #endregion

    void CreateBulletsParent()
    {
        projectilesParent = GameObject.Find(BULLETS_PARENT_NAME);
        if (!projectilesParent)
        {
            projectilesParent = new GameObject(BULLETS_PARENT_NAME);
        }
    }

    public void SetGunPos(Camera mainCamera)
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = gunZAxis + transform.position.z;
        gun.position = mainCamera.ScreenToWorldPoint(mousePos);         
        gun.rotation = mainCamera.transform.rotation;
    }

    public void Shoot()
    {

        Instantiate(bullet, gun.position, gun.rotation, projectilesParent.transform);

        //RaycastHit hit;
        //if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range))
        //{
        //    ProcessHit(hit);
        //}
        //else
        //{
        //    return;
        //}
    }


}
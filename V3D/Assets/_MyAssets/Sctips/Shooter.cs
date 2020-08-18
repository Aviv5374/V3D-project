using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    const string BULLETS_PARENT_NAME = "Bullets";
    
    [SerializeField] Bullet bullet;
    [SerializeField] Transform gun;    
    [SerializeField] float gunZAxis = 5f;

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
        gun.rotation = Camera.main.transform.rotation;
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

    public Vector3 SetTarget(Camera mainCamera)
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = gunZAxis;        
        return mainCamera.ScreenToWorldPoint(mousePos);        
    }

    public void Shoot(Camera mainCamera)
    {

        Bullet tempBullet = Instantiate(bullet, gun.position, gun.rotation, projectilesParent.transform);
        tempBullet.target = SetTarget(mainCamera);
        
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    const string BULLETS_PARENT_NAME = "Bullets";
    
    [SerializeField] Bullet bullet;
    [SerializeField] Transform gun;
    [SerializeField] float distanceRay = 100f;
    [SerializeField] LayerMask layerMask;

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

    public void SetGunRotation(Quaternion cameraRotation)
    {
        gun.rotation = cameraRotation;
    }

    public void Shoot(Camera mainCamera)
    {
        Debug.Log("LOL1");        
        Bullet tempBullet = Instantiate(bullet, gun.position, gun.rotation, projectilesParent.transform);
        tempBullet.target = SetTarget(mainCamera).normalized;        
    }

    Vector3 SetTarget(Camera mainCamera)
    {                           
        Vector3 clickPos = -Vector3.one;
        Ray mouseRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(mouseRay, out hitInfo, distanceRay, layerMask))
        {
            Debug.Log("mouseRay Pos: " + hitInfo.point);
            clickPos = hitInfo.point;
        }
        return clickPos;
    }


}
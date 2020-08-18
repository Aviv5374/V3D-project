using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    const string PROJECTILES_PARENT_NAME = "Projectiles";
    
    [SerializeField] Bullet bullet;
    [SerializeField] Transform gun;//???

    GameObject projectilesParent;

    #region Initialization

    void Awake()
	{
		
	}
			
    void Start()
    {
        CreateProjectilesParent();
    }
     
    #endregion

    #region Updating	 

    void Update()
    {
        
    }

    #endregion

    void CreateProjectilesParent()
    {
        projectilesParent = GameObject.Find(PROJECTILES_PARENT_NAME);
        if (!projectilesParent)
        {
            projectilesParent = new GameObject(PROJECTILES_PARENT_NAME);
        }
    }

    public void Shoot()
    {

        Instantiate(bullet, gun.position, Quaternion.identity, projectilesParent.transform);

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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] Bullet bullet;

    #region Initialization

    void Awake()
	{
		
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

    public void Shoot()
    {
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    const string BULLETS_PARENT_NAME = "Bullets";
    
    [SerializeField] Bullet bullet;
    [SerializeField] Transform gun;    
    [SerializeField] float gunZAxis = 5f;
    [SerializeField] float raycastRadius = 1f;
    [SerializeField] float range = 10000f;

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
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z);
        Debug.Log("mousePos:" + mousePos);
        Debug.Log("mainCamera.ScreenToWorldPoint(mousePos): " + mainCamera.ScreenToWorldPoint(mousePos));
        return mainCamera.ScreenToWorldPoint(mousePos);
        //Ray mouseRay = mainCamera.ScreenPointToRay(mousePos);
        //RaycastHit hitInfo;
        //Physics.SphereCast(mouseRay, raycastRadius, out hitInfo);
        //return mouseRay.GetPoint(raycastRadius);        
    }

    public void Shoot(Camera mainCamera)
    {
        Debug.Log("LOL1");
        Vector3 clickPos = -Vector3.one;
        Ray mouseRay = mainCamera.ScreenPointToRay(Input.mousePosition);

        Plane plane = new Plane(Vector3.one, 0);
        float DistanceToPlane;
        if (plane.Raycast(mouseRay, out DistanceToPlane))
        {

            Debug.Log("mouseRay Pos: " + mouseRay.GetPoint(DistanceToPlane));
            clickPos = mouseRay.GetPoint(DistanceToPlane);
        }
        Vector3 finalClickPos = new Vector3(clickPos.x, clickPos.y, 1);

        //RaycastHit hitInfo;
        //if (Physics.Raycast(mouseRay, out hitInfo))
        //{
        //    Debug.Log("mouseRay Pos: " + hitInfo.point);
        //    clickPos = hitInfo.point;
        //}        


        //Bullet tempBullet = Instantiate(bullet, gun.position, Quaternion.LookRotation(finalClickPos), projectilesParent.transform);
        Bullet tempBullet = Instantiate(bullet, clickPos, Quaternion.identity, projectilesParent.transform);
        tempBullet.target = clickPos; //SetTarget(mainCamera);
        
    }


}
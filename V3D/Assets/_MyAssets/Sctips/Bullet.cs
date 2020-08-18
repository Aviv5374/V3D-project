using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 4.5f;


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
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
	
	#endregion
		
}
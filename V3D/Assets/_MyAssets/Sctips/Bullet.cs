using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 4.5f;
    [SerializeField] float maxLifeTime = 7f;

    #region Initialization

    void Awake()
	{
		
	}
			
    void Start()
    {
        //transform.LookAt(GetAimLocation());
        Destroy(gameObject, maxLifeTime);
    }

    #endregion

    void OnTriggerEnter(Collider other)
    {
        
    }

    #region Updating	 

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
	
	#endregion
		
}
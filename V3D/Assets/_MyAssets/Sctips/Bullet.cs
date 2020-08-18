using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Vector3 target;

    [SerializeField] float speed = 4.5f;
    [SerializeField] float maxLifeTime = 7f;
    [SerializeField] float gunZAxis = 5f;

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
        //Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        transform.Translate(target * speed * Time.deltaTime);
    }
	
	#endregion
		
}
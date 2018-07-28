using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour {

	public float moveSpeed;


	void Start () {
		
	}
	

	void Update () 
	{
		MoveGround();
		DestroyGround();
		
	}


	void MoveGround()
	{
		transform.position -= new Vector3(moveSpeed, 0, 0);

	}

	void DestroyGround()
	{
		if (transform.position.x <= -20)
		{
			Destroy(gameObject);
		}

	}




}




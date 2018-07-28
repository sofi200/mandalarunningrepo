using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour {

	public GameObject groundPrefab;
	public GameObject orbPrefab;
	private float randNum;

	// Use this for initialization
	void Start () 
	{
	    //Comienza la rutina de creacion de ground
		StartCoroutine("SpawGround");
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	//Corutina que corre crea un nuevo ground y luego espera un tiempo (1.5 seg) y vuelve a crear otra ground
	IEnumerator SpawGround()
	{
		int randorb = Random.Range (0, 100);
		float yaxis = Random.Range (0.5f,2);
	    //Crea un nuevo game object ground a partir a partir del prefab declarado arriba y lo guardan en su propia variable 
		GameObject clon = Instantiate(groundPrefab, new Vector3 (10, -4.75f, 0), Quaternion.identity);

		if (randorb <= 50) 
		{
			GameObject orbClon = Instantiate (orbPrefab, new Vector3 (0, 0, 0), Quaternion.identity);
			orbClon.transform.parent = clon.transform;
			orbClon.transform.localPosition = new Vector3 (0, yaxis, 0);
		}
		clon.GetComponent<SpriteRenderer>().size = new Vector2 (Random.Range (0.7F, 1.5F), 0.7F);
		randNum = Random.Range (0.5f, 1.5f);

		yield return new WaitForSeconds(randNum);
		StartCoroutine("SpawGround");


	}
		
	


}















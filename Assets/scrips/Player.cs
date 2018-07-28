using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	//Declarar variable que contenga el Rigid de Player
	private Rigidbody2D rb;

	//Variable publica que contenga la fuerza que se le aplica al salto
	public float JumpSpeed;
	private int jumpCount;  
	private int orbCount;
	public Image orbBar;
	private bool enablePower = false;
	void Start () 
	{
		//Llenar la variable "rb" con el componente Rigidbod2D del Jugador
		rb = gameObject.GetComponent<Rigidbody2D>();
		orbBar.fillAmount = 0;
	}



	// Update is called once per frame
	void Update () 
	{		
		//Verifica cuando el usuario apreto la tecla espacio
		if (Input.GetKeyDown (KeyCode.Space))
		{			
			if (jumpCount < 2) 
			{
				rb.velocity = new Vector2(0, 0);
				rb.AddForce (new Vector2 (0, JumpSpeed));
				jumpCount++;
			}
		}

		if (enablePower)
		
		{
		   PowerUp();
		}
	  	
	}

	void OnCollisionEnter2D(Collision2D collider)
	{
		if (collider.gameObject.tag == "ground")
		{
			jumpCount = 0;
		}
	}



	void OnTriggerEnter2D(Collider2D trigger)
	{


		if (trigger.gameObject.tag == "Orb")
		{
			orbCount += 1;
			orbBar.fillAmount += 0.1f;

			if(enablePower == false)

			if (orbCount >= 10)
			{
				enablePower = true;
				orbCount = 0;
			}


			Destroy(trigger.gameObject);
		}
	}



	public void PowerUp()
	{
		if (enablePower)
		
		{
			if (orbBar.fillAmount <= 0)
			{
				enablePower = false;
			}


		}	
		orbBar.fillAmount -= 0.1f * Time.deltaTime;
	}
}











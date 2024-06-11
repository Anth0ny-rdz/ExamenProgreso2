using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auto : MonoBehaviour
{
	/// Velocidad de avance y retroceso del coche
	public float speed = 10f;

	// Velocidad de giro del coche
	public float turnSpeed = 50f;

	void Update()
	{
		// Control de avance y retroceso
		float move = 0f;
		if (Input.GetKey(KeyCode.W))
		{
			move = 1f;
		}
		else if (Input.GetKey(KeyCode.S))
		{
			move = -1f;
		}

		// Control de giro
		float turn = 0f;
		if (Input.GetKey(KeyCode.A))
		{
			turn = -1f;
		}
		else if (Input.GetKey(KeyCode.D))
		{
			turn = 1f;
		}

		// Aplicar movimiento y giro
		transform.Translate(Vector3.forward * move * speed * Time.deltaTime);
		transform.Rotate(Vector3.up, turn * turnSpeed * Time.deltaTime);
	}

	
}

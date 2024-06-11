using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	// El objeto a seguir (por ejemplo, el coche)
	public Transform target;

	// Altura de la c�mara sobre el objetivo
	public float height = 10f;

	// Distancia detr�s del objetivo
	public float distance = 5f;

	// Velocidad de seguimiento de la c�mara
	public float smoothSpeed = 0.125f;

	private Vector3 offset;

	void Start()
	{
		// Calcular el offset inicial basado en la altura y la distancia
		offset = new Vector3(0, height, -distance);
	}

	void LateUpdate()
	{
		// Posici�n deseada de la c�mara
		Vector3 desiredPosition = target.position + offset;

		// Posici�n suavizada de la c�mara
		Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

		// Actualizar la posici�n de la c�mara
		transform.position = smoothedPosition;

		// Mantener la c�mara mirando hacia abajo
		transform.rotation = Quaternion.Euler(90f, 0f, 0f);
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "pared")
		{
			print("ENTER");
		}
	}
	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "pared")
		{
			print("STAY");
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "pared")
		{
			print("EXIT");
		}
	}
}

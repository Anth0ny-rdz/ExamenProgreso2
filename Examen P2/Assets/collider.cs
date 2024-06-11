using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{
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

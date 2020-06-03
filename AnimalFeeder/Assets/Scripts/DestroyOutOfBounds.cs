using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Destruye los objetos instanciados cuando
 * salen de la escena
 */
public class DestroyOutOfBounds : MonoBehaviour
{
	public float topBound = 30f;
	public float lowBound = -10f;

	void Update()
	{
		if (transform.position.z > topBound)
		{
			Destroy(gameObject);
		}
		else if (transform.position.z < lowBound)
		{
			Destroy(gameObject);
		}
	}
}
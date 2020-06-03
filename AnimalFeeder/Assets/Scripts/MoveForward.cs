using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Mueve la comida y los animales hacia adelante
 */
public class MoveForward : MonoBehaviour
{
	public float speed = 14f;

	void Update()
	{
		transform.Translate(Vector3.forward * (Time.deltaTime * speed));
	}
}
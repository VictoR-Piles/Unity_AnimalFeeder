using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMove : MonoBehaviour
{
	public float speed = 14f;

	void Start()
	{
	}

	void Update()
	{
		transform.Translate(Vector3.forward * (Time.deltaTime * speed));
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed = 10f;
	public float xRange = 10f;
	public GameObject food;
	
	private float horizontalInput;

	void Start()
	{
	}

	void Update()
	{
		if (transform.position.x < -xRange)
		{
			transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
		}
		else if (transform.position.x > xRange)
		{
			transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
		}

		horizontalInput = Input.GetAxis("Horizontal");
		transform.Translate(Vector3.right * (horizontalInput * Time.deltaTime * speed));

		if (Input.GetKeyDown(KeyCode.Space))
		{
			
		}
	}
}
// https://learn.unity.com/tutorial/lesson-2-2-launch-projectiles-by-instantiating-prefabs?language=en&courseId=5cf96c41edbc2a2ca6e8810f&projectId=5cdcc312edbc2a24a41671e6#5ce3479eedbc2a274fe5904f
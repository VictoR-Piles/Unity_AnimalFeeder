using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

/**
 * Se encarga de manejar el input y el control del Player
 */
public class PlayerController : MonoBehaviour
{
	public float speed = 10f;
	public float xRange = 10f;
	public GameObject foodPrefab;

	private float horizontalInput;

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
			Instantiate(foodPrefab, transform.position, foodPrefab.transform.rotation);
		}
	}
}
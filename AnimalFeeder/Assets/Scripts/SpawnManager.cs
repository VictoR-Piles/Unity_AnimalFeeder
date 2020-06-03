using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Se encarga de spawnear animales de manera random
 */
public class SpawnManager : MonoBehaviour
{
	public GameObject[] animalsPrefab;
	public int spawnRangeX = 20;
	public int spawnRangeZ = 20;
	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.S))
		{
			int randomAnimal = Random.Range(0, animalsPrefab.Length);
			int randomPosX = Random.Range(-spawnRangeX, spawnRangeX);

			Vector3 spawnPos = new Vector3(randomPosX, 0, spawnRangeZ);

			Instantiate(animalsPrefab[randomAnimal], spawnPos, animalsPrefab[randomAnimal].transform.rotation);
		}
	}
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

/**
 * Se encarga de spawnear animales de manera random
 */
public class SpawnManager : MonoBehaviour
{
	public GameObject[] animalsPrefab;
	public int spawnRangeX = 20;
	public int spawnRangeZ = 20;

	private int randomAnimal;
	private int randomPosX;
	private float startDelay = 2f;
	private float spawnInterval = 1.5f;

	void Start()
	{
		InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval - Random.Range(0, .5f));
	}

	void Update()
	{
	}

	void SpawnRandomAnimal()
	{
		randomAnimal = Random.Range(0, animalsPrefab.Length);
		randomPosX = Random.Range(-spawnRangeX, spawnRangeX);

		Vector3 spawnPos = new Vector3(randomPosX, 0, spawnRangeZ);

		Instantiate(animalsPrefab[randomAnimal], spawnPos, animalsPrefab[randomAnimal].transform.rotation);
	}
}
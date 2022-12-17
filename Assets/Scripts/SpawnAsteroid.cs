using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroid : MonoBehaviour
{
	public GameObject[] animalPrefabs;
	private float spawnRangeX = 20;
	private float spawnPosZ = 20;
	private float startDelay = 	8;
	private float spawnInterval = 2.5f;
	
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }
	
    // Update is called once per frame
    void Update()
    {
        
		
    }
	void SpawnRandomAnimal(){
		//randomizes the spawns from 0-3 in the array. array length is 3 so it sets length to 3
			Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
			
			int animalIndex = Random.Range(0, animalPrefabs.Length);
			Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
	}
}

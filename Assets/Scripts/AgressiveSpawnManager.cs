using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgressiveSpawnManager : MonoBehaviour
{
    public GameObject[] agressiveAnimalPrefabs;
    private float spawnRangeZ = 20.0f;
    private float spawnPosX = 20.0f;
    private float startDelay = 3;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnAgrRandomAnimal", startDelay, spawnInterval);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnAgrRandomAnimal();
        }
    }


    private void SpawnAgrRandomAnimal()
    {
        int animalIndex = UnityEngine.Random.Range(0, agressiveAnimalPrefabs.Length);
        int a = Random.Range(0, 2);

        if(a == 0) 
        {
            Vector3 spawnPos = new Vector3(spawnPosX, 0, UnityEngine.Random.Range(0, spawnRangeZ));
            Instantiate(agressiveAnimalPrefabs[animalIndex], spawnPos, agressiveAnimalPrefabs[animalIndex].transform.rotation);
        } else
        {
            Vector3 spawnPos = new Vector3(-spawnPosX, 0, UnityEngine.Random.Range(0, spawnRangeZ));
            Instantiate(agressiveAnimalPrefabs[animalIndex], spawnPos, (agressiveAnimalPrefabs[animalIndex].transform.rotation) );
            agressiveAnimalPrefabs[animalIndex].transform.Rotate(0, 180, 0);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; // Groups of animals
    public GameObject[] animalPrefabsRight;
    public GameObject[] animalPrefabsLeft;
    private float spawnRangeX = 10;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); //Repeat spawning the animals
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // Randomly generate animal index and spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); //Spawns the animals from the top
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        
        int animalIndexRight = Random.Range(0, animalPrefabsRight.Length);
        Vector3 spawnPosRight = new Vector3(25, 0, Random.Range(5, 15));
        Instantiate(animalPrefabsRight[animalIndexRight], spawnPosRight, animalPrefabsRight[animalIndexRight].transform.rotation);
        // Spawns animals from the right
        int animalIndexLeft = Random.Range(0, animalPrefabsLeft.Length);
        Vector3 spawnPosLeft = new Vector3(-25, 0, Random.Range(5, 15));
        Instantiate(animalPrefabsLeft[animalIndexLeft], spawnPosLeft, animalPrefabsLeft[animalIndexLeft].transform.rotation);
        // Spawns animals from the left
    }
}

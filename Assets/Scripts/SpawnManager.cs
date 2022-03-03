using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalPrefabs;
    private int spawnRangeX = 20;
    private int spawnRangeZ = 17;
    private float invokeTime = 4;
    private Quaternion rotation = new Quaternion();
    public float ratio = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnAnimalFromZ", invokeTime, ratio);
        InvokeRepeating("SpawnAnimalFromX", invokeTime, ratio);
        InvokeRepeating("SpawnAnimalFromXReverse", invokeTime, ratio);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnAnimalFromZ()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int randomPosition = Random.Range(-spawnRangeX, spawnRangeX);
        Instantiate(animalPrefabs[animalIndex], new Vector3(randomPosition, 0, 30),
         animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnAnimalFromX()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int randomPosition = Random.Range(2, spawnRangeZ);
        var animalRotation = Quaternion.Euler(0,90,0);
        Instantiate(animalPrefabs[animalIndex], new Vector3(-25, 0, randomPosition),
         animalRotation);
    }
    void SpawnAnimalFromXReverse()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int randomPosition = Random.Range(2, spawnRangeZ);
        var animalRotation = Quaternion.Euler(0,-90,0);
        Instantiate(animalPrefabs[animalIndex], new Vector3(25, 0, randomPosition),
         animalRotation);
    }
}

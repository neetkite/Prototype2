using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalPrefabs;
    private int spawnRangeX = 20;
    private float invokeTime = 1;
    public float ratio = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnAnimal", invokeTime, ratio);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int randomPosition = Random.Range(-spawnRangeX, spawnRangeX);
        Instantiate(animalPrefabs[animalIndex], new Vector3(randomPosition, 0, 30),
         animalPrefabs[animalIndex].transform.rotation);
    }
}

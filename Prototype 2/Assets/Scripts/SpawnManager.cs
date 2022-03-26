using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnRangeX = 15f;
    public float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        var i = Random.Range(0, animalPrefabs.Length);
        var x = Random.Range(-spawnRangeX, spawnRangeX);
        var position = new Vector3(x, 0, spawnPosZ);
        Instantiate(animalPrefabs[i], position, animalPrefabs[i].transform.rotation);
    }
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEditor;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    private float spawnrangex = 110;
    private float spawnposz = 100;

    private float startdelay = 2;
    private float intervaldelay = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", startdelay, intervaldelay);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnAnimal()
    {
        int index = Random.Range(0, animals.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-spawnrangex, spawnrangex), -20, spawnposz);

        Instantiate(animals[index], spawnpos, animals[index].transform.rotation);
    }
}

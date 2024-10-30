using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] wrogowie;
    private float startTime = 1.0f;
    private float spawnRate = 4.0f;

    Vector3 spawnPos1 = new Vector3(-8, 7, 0);
    Vector3 spawnPos2 = new Vector3(8, 7, 0);
    Vector3 spawnPos3 = new Vector3(8, -7, 0);
    Vector3 spawnPos4 = new Vector3(-8, -7, 0);
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("Spawn", startTime, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     void Spawn()
    {
    int indeks1 = Random.Range(0,wrogowie.Length);
    int indeks2 = Random.Range(0,wrogowie.Length);
    int indeks3 = Random.Range(0,wrogowie.Length);
    int indeks4 = Random.Range(0,wrogowie.Length);

    Instantiate(wrogowie[indeks1], spawnPos1, wrogowie[indeks1].transform.rotation);
    Instantiate(wrogowie[indeks2], spawnPos2, wrogowie[indeks2].transform.rotation);
    Instantiate(wrogowie[indeks3], spawnPos3, wrogowie[indeks3].transform.rotation);
    Instantiate(wrogowie[indeks4], spawnPos4, wrogowie[indeks4].transform.rotation);

    }
}

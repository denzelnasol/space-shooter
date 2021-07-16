using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTime = 3f;

    float randomX = 0f;
    float randomY = 0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
        randomX = Random.Range(-9, 9);
        randomY = 7;
        GameObject.Instantiate(enemy, new Vector3(randomX, randomY, 0), enemy.transform.rotation); 
    }
}

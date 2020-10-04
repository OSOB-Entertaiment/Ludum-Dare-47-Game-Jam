using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    private float randX;
    private Vector2 whereToSpawn;
    public float spawnRate = 0f;
    private float nextSpawn = 0.0f;
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn    = Time.time + spawnRate;
            randX        = Random.Range(-8.4f, 8.4f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
    }
}

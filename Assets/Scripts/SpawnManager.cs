using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;

    private float spawnRange = 9;
    private int enemyCount;
    private int waveNum = 1;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(powerupPrefab, GenerateRandomSpawnPoint(), powerupPrefab.transform.rotation);
        SpawnEnemyWave(1);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0 )
        {
            waveNum++;
            SpawnEnemyWave(waveNum);
            Instantiate(powerupPrefab, GenerateRandomSpawnPoint(), powerupPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateRandomSpawnPoint()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return spawnPos;
    }

    void SpawnEnemyWave(int enemyToSpawn)
    {
        for (int i = 0; i < enemyToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateRandomSpawnPoint(), enemyPrefab.transform.rotation);
        }
    }
}

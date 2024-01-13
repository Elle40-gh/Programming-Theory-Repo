using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> enemyPrefabs;
    public List<GameObject> powerupPrefabs;

    private float spawnRange = 9;
    private int enemyCount;
    private int waveNum = 1;

    // Start is called before the first frame update
    void Start()
    {
        int randomPowerup = Random.Range(0, powerupPrefabs.Count);
        Instantiate(powerupPrefabs[randomPowerup], GenerateRandomSpawnPoint(), powerupPrefabs[randomPowerup].transform.rotation);
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
            int randomPowerup = Random.Range(0, powerupPrefabs.Count);
            Instantiate(powerupPrefabs[randomPowerup], GenerateRandomSpawnPoint(), powerupPrefabs[randomPowerup].transform.rotation);
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
            int randomEnemy = Random.Range(0, enemyPrefabs.Count);
            Instantiate(enemyPrefabs[randomEnemy], GenerateRandomSpawnPoint(), enemyPrefabs[randomEnemy].transform.rotation);
        }
    }
}

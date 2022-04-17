using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;
    
    [SerializeField]
    private GameObject powerupPrefab;
    
    private float spawnRange = 9;

    private int enemyCount;

    private int waveNumber = 1;

    private Vector3 powerupOffset = new Vector3(0, 0.5f, 0);
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy(waveNumber);

    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<EnemyController>().Length;

        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemy(waveNumber);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosY = Random.Range(-spawnRange, spawnRange);
        
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosY);
        
        return randomPos;
    }

    private void SpawnEnemy(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), Quaternion.identity);
            StartCoroutine(PowerupSpawnTime());
        }
    }

    private void SpawnPowerup()
    {
        Instantiate(powerupPrefab, GenerateSpawnPosition() + powerupOffset, Quaternion.identity);
    }
    
    public IEnumerator PowerupSpawnTime()
    {
        yield return new WaitForSeconds(5);
        SpawnPowerup();
    }
    
}

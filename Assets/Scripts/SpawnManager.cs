using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    private float spawnRange = 9;
    
    // Start is called before the first frame update
    void Start()
    {
        RandomSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RandomSpawn()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosY = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosY);

        Instantiate(enemyPrefab, randomPos, Quaternion.identity);
    }
    
}

using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    #region Fields
    [SerializeField]
    GameObject enemyPrefab;
    [SerializeField]
    GameObject powerupPrefab;
    float spawnRange = 9;
    int waveNumber = 1;
    int enemyCount;
    #endregion

    #region Unity methods
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
        SpawnPowerUp();
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if(enemyCount == 0) 
        { 
            waveNumber++; 
            SpawnEnemyWave(waveNumber);
            SpawnPowerUp();
        }
    }
    #endregion

    #region Private methods
    private void SpawnEnemyWave(int enemyToSpawn)
    {
        for(int i = 0; i < enemyToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    private void SpawnPowerUp()
    {
        Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
    }
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
    #endregion
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //variables
    public GameObject[] enemyPrefab;
    private float spawnRangeZMax = 89;
    private float spawnRangeZMin = -45;
    private float spawnPosX = -375;
    private float startDelay = 2;
    private float spawnInterval = 5;
    private PlayerController playerControllerScript;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void SpawnRandomEnemy()
    {
        //Local Variables
        Vector3 spawnPos = new Vector3(spawnPosX, 10, Random.Range(spawnRangeZMin, spawnRangeZMax));
        int enemyIndex = Random.Range(0, enemyPrefab.Length);

        //Sapwn Enemies
        if (gameManager.isGameActive)
        {
            Instantiate(enemyPrefab[enemyIndex], spawnPos, enemyPrefab[enemyIndex].transform.rotation);
        }

    }
    
}

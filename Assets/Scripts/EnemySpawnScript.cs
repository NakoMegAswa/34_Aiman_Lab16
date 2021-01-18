using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject EnemyPrefab;          //EnemyPrefab
    public float spawnInterval;             //Interval between each spawn

    // Spawn Area //
    public float minX;                      //minX position
    public float maxX;                      //maxX position
    public float minZ;                      //minZ position
    public float maxZ;                      //maxZ position
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitAndSpawn(spawnInterval));
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private IEnumerator WaitAndSpawn(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);

            Vector3 spawnPosition = new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ));

            Instantiate(EnemyPrefab, spawnPosition, Quaternion.identity);
        }
    }
}

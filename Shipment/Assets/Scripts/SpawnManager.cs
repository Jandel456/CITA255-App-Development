using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class RandomSpawner : MonoBehaviour
{
    public GameObject spawnedEnemy;
    public GameObject spawnedItem;
    public GameObject backgroundBounds;
    public float spawnEnemyMinTime = 3f;
    public float spawnEnemyMaxTime = 6f;
    public float spawnItemMinTime = 5f;
    public float spawnItemMaxTime = 10f;
    public bool spawnItemIsOnCooldown = false;
    public bool spawnEnemyIsOnCooldown = false;
    public List<GameObject> enemies = new List<GameObject>();   //ARRAY
    public Transform[] spawnPoints; //LIST
    public GameObject enemyProject;

    void SpawnEnemYForProject() // for this you will see a red shark 
    {
        foreach (Transform spawnPoint in spawnPoints)
        {
            GameObject enemy = Instantiate(enemyProject, spawnPoint.position, spawnPoint.rotation);
            enemies.Add(enemy);
        }
    }

    void Update()
    {
        if (!spawnEnemyIsOnCooldown)
        {
            SpawnObject(spawnedEnemy);
            spawnEnemyIsOnCooldown = true; 
        }

        if (!spawnItemIsOnCooldown)
        {
            SpawnObject(spawnedItem);
            spawnItemIsOnCooldown = true; 
        }
    }
    
    void SpawnObject(GameObject objectToSpawn)
    {
        // Get the bounds of the large square object
        BoxCollider2D backgroundBoundsCollider = backgroundBounds.GetComponent<BoxCollider2D>();

        if (backgroundBoundsCollider != null) // In here we're using the center of the background + the size of the background as the bounds for our random position. 
        {
            Vector2 center = backgroundBoundsCollider.offset; // Center of the 2D box collider
            Vector2 size = backgroundBoundsCollider.size; // Size of the 2D box collider

            float randomX = Random.Range(center.x - size.x / 2, center.x + size.x / 2);
            float randomY = Random.Range(center.y - size.y / 2, center.y + size.y / 2);

            Vector2 randomPosition = new Vector2(randomX, randomY);

            //we choose which object to spawn like the shark, item to pull, or something else if we really want, the code is really flexable
            Instantiate(objectToSpawn, randomPosition, Quaternion.identity);

            // we check if the spawned object is an enemy to assign it a different spawning cooldown
            if (objectToSpawn == spawnedEnemy)
            {
                StartCoroutine(SpawnCooldown(spawnEnemyMinTime, spawnEnemyMaxTime));
            }
            else if (objectToSpawn == spawnedItem)
            {
                StartCoroutine(SpawnCooldown(spawnItemMinTime, spawnItemMaxTime));
            }
        }
        else
        {
            Debug.Log("I'm stupid and I either never attached this to the background, or the background has no colider");
        }
    }
    private IEnumerator SpawnCooldown(float minTime, float maxTime)
    {
        // we dont want spawns to happen EXACTLY withint he same time each time, or it gets boring, so we make things spawn in a semi random way.
        float countdownTime = Random.Range(minTime, maxTime);
        while (countdownTime > 0)
        {
            countdownTime -= 1;
            yield return new WaitForSeconds(1);
        }

        //Here we make the item or enemy spawnable again.
        if (spawnItemIsOnCooldown)
        {
            spawnItemIsOnCooldown = false;
        }
        else if (spawnEnemyIsOnCooldown)
        {
            spawnEnemyIsOnCooldown = false;
        }
    }
}
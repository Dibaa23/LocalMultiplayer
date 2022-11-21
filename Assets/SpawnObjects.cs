using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject peoplePrefab;
    public GameObject magnetPrefab;
    public GameObject freezePrefab;
    public GameObject ghostPrefab;
    public GameObject speedPrefab;
    public GameObject clonePrefab;
    public GameObject timePrefab;
    public GameObject gemsPrefab;
    public GameObject astroidPrefab;
    private float spawnRangeX = 30f;
    private float spawnRangeY = 30f;
    private float GemspawnRate = 0.25f;
    private float AstroidSpawnRate = 5f;
    private float AstroidDespawnRate = 3f;
    private float GemdespawnRate = 2f;

    private void Start()
    {
        Vector2 randomPos = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY));
        InvokeRepeating("SpawnGems", 1f, GemspawnRate); 
        InvokeRepeating("DestroyGems", 1f, GemdespawnRate);
        InvokeRepeating("SpawnSpeedPwp", 5f, 3);
        InvokeRepeating("SpawnMagnetPwp", 5f, 4);
        InvokeRepeating("SpawnTimePwp", 10f, 5);
        InvokeRepeating("SpawnFreezePwp", 10f, 6);
        InvokeRepeating("SpawnClonePwp", 15f, 7);
        InvokeRepeating("SpawnGhostPwp", 15f, 8);
        InvokeRepeating("DestroySpeedPwp", 5f, 10);
        InvokeRepeating("DestroyMagnetPwp", 5f, 10);
        InvokeRepeating("DestroyTimePwp", 10f, 10);
        InvokeRepeating("DestroyFreezePwp", 10f, 10);
        InvokeRepeating("DestroyClonePwp", 15f, 10);
        InvokeRepeating("DestroyGhostPwp", 15f, 10);
        InvokeRepeating("SpawnAstroids", 60f, AstroidSpawnRate);

        //Spawning the people
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);

        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);

        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);

        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);

        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);

        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);

        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);

        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);

        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);

        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);

        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);

        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);

        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);

        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);

        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);

        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);

        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);

        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);

        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);

        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        Instantiate(peoplePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);


    }

    void SpawnGems()
    {
        Instantiate(gemsPrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
    }

    void SpawnAstroids()
    {
        Instantiate(astroidPrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
        StartCoroutine(DespawnAstroids(AstroidDespawnRate));
    }

    IEnumerator DespawnAstroids(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(GameObject.FindGameObjectWithTag("Impact"));
    }

    void DestroyGems()
    {
        Destroy(GameObject.FindWithTag("Gems"));
    }

    void SpawnMagnetPwp()
    {
        Instantiate(magnetPrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
    }

    void SpawnGhostPwp()
    {
        Instantiate(ghostPrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
    }

    void SpawnFreezePwp()
    {
        Instantiate(freezePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
    }

    void SpawnSpeedPwp()
    {
        Instantiate(speedPrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
    }

    void SpawnClonePwp()
    {
        Instantiate(clonePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
    }

    void SpawnTimePwp()
    {
        Instantiate(timePrefab, new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY)), Quaternion.identity);
    }

    void DestroyMagnetPwp()
    {
        Destroy(GameObject.FindGameObjectWithTag("Magnet"));
    }

    void DestroyGhostPwp()
    {
        Destroy(GameObject.FindGameObjectWithTag("Ghost"));
    }

    void DestroyFreezePwp()
    {
        Destroy(GameObject.FindGameObjectWithTag("Freeze"));
    }

    void DestroySpeedPwp()
    {
        Destroy(GameObject.FindGameObjectWithTag("Speed"));
    }

    void DestroyClonePwp()
    {
        Destroy(GameObject.FindGameObjectWithTag("Clone"));
    }

    void DestroyTimePwp()
    {
        Destroy(GameObject.FindGameObjectWithTag("Time"));
    }

}

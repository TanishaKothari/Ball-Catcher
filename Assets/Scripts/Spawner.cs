using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawning;
    public float spawnTime;
    public float spawnDelay;
    int screenWidth;
    int screenHeight;
    Vector3 screenToWorldPos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBalls", spawnTime, spawnDelay);
    }

    public void SpawnBalls()
    {
        Instantiate(spawnee, RandomPosition(), transform.rotation);
    }

    Vector3 RandomPosition()
    {
        screenWidth = Screen.width;
        screenHeight = Screen.height;
        screenToWorldPos = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, screenWidth), screenHeight, 1));
        return screenToWorldPos;
    }
} //class

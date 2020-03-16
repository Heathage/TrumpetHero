using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject[] obstacleNotes;
    public int note;
    public int spawnedNote;
    public float spawnPosX;
    public float spawnPosY;
    public bool spawned = false;
    public float spawnTime = 0;
    public float difficultyTimer = 12;
    public float easy = 3f;
    public float medium = 2f;
    public float hard = 1f;

    void Start()
    {
        spawnTime = easy;
        StartCoroutine(IncreaseDifficulty());
    }

    void Update()
    {
        if(!spawned)
        {
            StartCoroutine(Spawn());
        }
    }

    private IEnumerator Spawn()
    {
        spawned = true;
        yield return new WaitForSecondsRealtime(spawnTime);
        getSpawnPos();
        Instantiate(obstacle, new Vector3(spawnPosX, spawnPosY), Quaternion.identity);

        if(spawnTime == medium)
        {
            getSpawnPos();
            Instantiate(obstacle, new Vector3(spawnPosX, spawnPosY), Quaternion.identity);
        }

        if(spawnTime == hard)
        {
            getSpawnPos();
            Instantiate(obstacle, new Vector3(spawnPosX, spawnPosY), Quaternion.identity);
            getSpawnPos();
            Instantiate(obstacle, new Vector3(spawnPosX, spawnPosY), Quaternion.identity);
        }

        spawned = false;
    }

    private IEnumerator IncreaseDifficulty()
    {
        yield return new WaitForSecondsRealtime(difficultyTimer);
        spawnTime = medium;
        yield return new WaitForSecondsRealtime(difficultyTimer);
        spawnTime = hard;
    }

    private void getSpawnPos()
    {
        do
        {
            note = Random.Range(0, 13);
        } 
        while (note == spawnedNote);

        spawnedNote = note;
        spawnPosX = obstacleNotes[note].transform.position.x;
        spawnPosY = obstacleNotes[note].transform.position.y;
    }
}
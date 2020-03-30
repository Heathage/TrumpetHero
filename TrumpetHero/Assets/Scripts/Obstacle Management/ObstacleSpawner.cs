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
    private float easy = 3f;
    private float medium = 2.5f;
    private float hard = 2.0f;

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
        if(spawnTime == easy)
        {
            spawnEasy();
        }

        if(spawnTime == medium)
        {
            spawnMedium();
        }

        if(spawnTime == hard)
        {
            spawnHard();
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
            note = Random.Range(0, 6);
        } 
        while (note == spawnedNote);

        spawnedNote = note;
        spawnPosX = obstacleNotes[note].transform.position.x;
        spawnPosY = obstacleNotes[note].transform.position.y;
    }

    private void spawnEasy()
    {
            getSpawnPos();
            Instantiate(obstacle, new Vector3(spawnPosX, spawnPosY), Quaternion.identity);
    }

    private void spawnMedium()
    {
        for (int i = 1; i <= 2; i++)
        {
            getSpawnPos();
            Instantiate(obstacle, new Vector3(spawnPosX, spawnPosY), Quaternion.identity);
        }
    }

    private void spawnHard()
    {
        for (int i = 1; i <= 4; i++)
        {
            getSpawnPos();
            Instantiate(obstacle, new Vector3(spawnPosX, spawnPosY), Quaternion.identity);
        }
    }
}
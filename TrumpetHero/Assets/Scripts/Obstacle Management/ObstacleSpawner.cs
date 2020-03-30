using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject[] obstacleNotes;

    private int note;
    private int spawnedNote;

    [Header("Note Position")]
    [SerializeField]
    private float spawnPosX;
    [SerializeField]
    private float spawnPosY;
    [Space]
    [SerializeField]
    private bool spawned = false;

    [Header("Difficulty")]
    [SerializeField]
    private float difficultyTimer = 30;
    private float spawnTime = 0;
    [SerializeField]
    private float easy = 2f;
    [SerializeField]
    private float medium = 1.7f;
    [SerializeField]
    private float hard = 1.4f;

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
            note = Random.Range(0, 5);
        } 
        while (note == spawnedNote);

        spawnedNote = note;
        spawnPosX = obstacleNotes[note].transform.position.x;
        spawnPosY = obstacleNotes[note].transform.position.y;
    }

    private void spawnEasy()
    {
        for (int i = 1; i <= 2; i++)
        {
            getSpawnPos();
            Instantiate(obstacle, new Vector3(spawnPosX, spawnPosY), Quaternion.identity);
        }
    }

    private void spawnMedium()
    {
        for (int i = 1; i <= 3; i++)
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// -----------------------------------------------------------------------------------------------------------
// <copyright file="ObstacleSpawner.cs">
// MIT Licence Copyright (c) 2020.
// </copyright>
// <author>James Mead Heath</author>
// <summary>
// Responsible for spawning the obstacles that will fly towards the player
// Uses an array to note spawn positions
// Has three different difficulty states, switching from one to another after a set time
// </summary>
// -----------------------------------------------------------------------------------------------------------

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

    //Starts the difficulty increase timers
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

    //Spawns a number of obstacles at a set time dependant on the difficulty
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

    //Increases the difficulty after an alloted time, twice
    private IEnumerator IncreaseDifficulty()
    {
        yield return new WaitForSecondsRealtime(difficultyTimer);
        spawnTime = medium;
        yield return new WaitForSecondsRealtime(difficultyTimer);
        spawnTime = hard;
    }

    //Gets a random number between 0 and 5, applying one of six spawn positions for an obstacle 
    private void getSpawnPos()
    {
        do
        {
            note = Random.Range(0, 5);
        } 
        //To try and avoid spawning obstacles in the same position
        while (note == spawnedNote);

        spawnedNote = note;
        spawnPosX = obstacleNotes[note].transform.position.x;
        spawnPosY = obstacleNotes[note].transform.position.y;
    }

    //Easy difficulty - to repeat get spawn position method twice. Spawning the obstacles. 
    private void spawnEasy()
    {
        for (int i = 1; i <= 2; i++)
        {
            getSpawnPos();
            Instantiate(obstacle, new Vector3(spawnPosX, spawnPosY), Quaternion.identity);
        }
    }

    //Medium difficulty - to repeat get spawn position method three times. Spawning the obstacles.
    private void spawnMedium()
    {
        for (int i = 1; i <= 3; i++)
        {
            getSpawnPos();
            Instantiate(obstacle, new Vector3(spawnPosX, spawnPosY), Quaternion.identity);
        }
    }

    //Hard difficulty - to repeat get spawn position method four times. Spawning the obstacles.
    private void spawnHard()
    {
        for (int i = 1; i <= 4; i++)
        {
            getSpawnPos();
            Instantiate(obstacle, new Vector3(spawnPosX, spawnPosY), Quaternion.identity);
        }
    }
}
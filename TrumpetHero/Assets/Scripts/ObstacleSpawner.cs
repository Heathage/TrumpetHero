using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject[] obstacleNotes;
    public int note;
    public float spawnPosX;
    public float spawnPosY;
    public bool spawned = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!spawned)
        {
            StartCoroutine(Spawn());
        }
    }
    private IEnumerator Spawn()
    {
        spawned = true;
        yield return new WaitForSecondsRealtime(2);
        note = Random.Range(0, 13);
        spawnPosX = obstacleNotes[note].transform.position.x;
        spawnPosY = obstacleNotes[note].transform.position.y;
        Instantiate(obstacle, new Vector3(spawnPosX, spawnPosY), Quaternion.identity);
        spawned = false;
    }
}
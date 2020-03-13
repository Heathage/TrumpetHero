using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject[] obstacleNotes;
    public int note;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Spawn());
    }
    private IEnumerator Spawn()
    {
        yield return new WaitForSecondsRealtime(2);
        note = Random.Range(0, 12);
        Vector3 spawnPos = obstacleNotes[note].transform.position;
        Debug.Log(spawnPos);
        //Instantiate(obstacle, spawnPos);
    }
}
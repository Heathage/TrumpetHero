using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDespawner : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D Obstacle)
    {
        Destroy(Obstacle.gameObject);
    }
}

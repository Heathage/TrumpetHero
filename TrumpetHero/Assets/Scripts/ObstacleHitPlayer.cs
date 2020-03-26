using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHitPlayer : MonoBehaviour
{
    public ScoreCounter alive;
    void OnCollisionEnter2D(Collision2D player)
    {
        Debug.Log("Hit");
        player.gameObject.SetActive(false);
        Destroy(gameObject);
    }
}

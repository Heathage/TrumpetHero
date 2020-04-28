using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// -----------------------------------------------------------------------------------------------------------
// <copyright file="ObstacleHitPlayer.cs">
// MIT Licence Copyright (c) 2020.
// </copyright>
// <author>James Mead Heath</author>
// <summary>
// Responsible for destorying the player when the obstacle hits the player.
// </summary>
// -----------------------------------------------------------------------------------------------------------

public class ObstacleHitPlayer : MonoBehaviour
{
    //Sets the player active state to false to start the death screen process.
    void OnCollisionEnter2D(Collision2D player)
    {
        Debug.Log("Hit");
        player.gameObject.SetActive(false);
        Destroy(gameObject);
    }
}

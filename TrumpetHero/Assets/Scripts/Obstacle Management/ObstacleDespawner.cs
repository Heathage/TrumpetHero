using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// -----------------------------------------------------------------------------------------------------------
// <copyright file="ObstacleDespawner.cs">
// MIT Licence Copyright (c) 2020.
// </copyright>
// <author>James Mead Heath</author>
// <summary>
// Responsible for removing the obstacles from the game.
// Prevents the obstacles from going on forever
// </summary>
// -----------------------------------------------------------------------------------------------------------

public class ObstacleDespawner : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Obstacle)
    {
        Destroy(Obstacle.gameObject);
    }
}

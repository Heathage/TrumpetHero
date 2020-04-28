using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// -----------------------------------------------------------------------------------------------------------
// <copyright file="ObstacleMovement.cs">
// MIT Licence Copyright (c) 2020.
// </copyright>
// <author>James Mead Heath</author>
// <summary>
// Responsible for moving the obstacles.
// </summary>
// -----------------------------------------------------------------------------------------------------------

public class ObstacleMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float speed = -10;

    //Applies a constant velocity to each obstacle, sending them to the left.
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(speed, 0, 0);
    }
}

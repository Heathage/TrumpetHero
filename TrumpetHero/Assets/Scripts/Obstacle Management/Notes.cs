using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// -----------------------------------------------------------------------------------------------------------
// <copyright file="Notes.cs">
// MIT Licence Copyright (c) 2020.
// </copyright>
// <author>James Mead Heath</author>
// <summary>
// Allows me to visualise the spawn positions of the obstacles and where the player can move.
// </summary>
// -----------------------------------------------------------------------------------------------------------

public class Notes : MonoBehaviour
{
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 0.05f);
    }
}

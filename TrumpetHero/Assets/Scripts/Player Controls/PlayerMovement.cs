using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// -----------------------------------------------------------------------------------------------------------
// <copyright file="PlayerMovement.cs">
// MIT Licence Copyright (c) 2020.
// </copyright>
// <author>James Mead Heath</author>
// <summary>
// Allows the player to move
// Uses an array to store the positions the player can move to
// This is for keyboard controls
// </summary>
// -----------------------------------------------------------------------------------------------------------

public class PlayerMovement : MonoBehaviour
{
    //Stores positions in an array
    public GameObject[] notes;
    [SerializeField]
    private int note = 2;

    private void Start()
    {
        gameObject.transform.position = notes[note].transform.position;
    }

    //Responsible for allowing the player to move up and down a position
    public void Update()
    {
        //Move up one
        if(Input.GetKeyUp(KeyCode.W))
        {
            if (note >= 1)
            {
                note--;
                gameObject.transform.position = notes[note].transform.position;
            }
        }

        //Move down one
        if (Input.GetKeyUp(KeyCode.S))
        {
            if (note <= 3)
            {
                note++;
                gameObject.transform.position = notes[note].transform.position;
            }
        }
    }



}

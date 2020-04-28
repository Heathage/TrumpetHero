using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

// -----------------------------------------------------------------------------------------------------------
// <copyright file="MovementTrumpetCon.cs">
// MIT Licence Copyright (c) 2020.
// </copyright>
// <author>James Mead Heath</author>
// <summary>
// Allows the player to move
// Determines the position of the player character based on valves pressed.
// This script is responsible for receiving the Input from the Arduino.
// </summary>
// -----------------------------------------------------------------------------------------------------------


public class MovementTrumpetCon : MonoBehaviour
{
    //Responsible for holding possible player positions
    public GameObject[] notes;
    [SerializeField]
    private int note = 2;

    //Defining the input port for the Arduino
    SerialPort sp = new SerialPort("COM3", 9600);

    private void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;

        //Updates player position based on note array value
        gameObject.transform.position = notes[note].transform.position;
    }

    private void Update()
    {
        gameObject.transform.position = notes[note].transform.position;

        if (sp.IsOpen)
        {
            try
            {
                playerPos(sp.ReadByte());
                print(sp.ReadByte());
            }
            catch (System.Exception)
            {

            }
        }
    }

    //Takes the value sent from the Arduino
    //Changes note to allow the array position transform to be accessed
    private void playerPos(int Valve)
    {
        if (Valve == 1)
        {
            note = Valve-1;
        }

        if (Valve == 2)
        {
            note = Valve-1;
        }

        if (Valve == 3)
        {
            note = Valve-1;
        }

        if (Valve == 4)
        {
            note = Valve-1;
        }

        if (Valve == 5)
        {
            note = Valve-1;
        }

    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class MovementTrumpetCon : MonoBehaviour
{
    public GameObject[] notes;
    [SerializeField]
    private int note = 2;

    SerialPort sp = new SerialPort("COM3", 9600);

    private void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
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


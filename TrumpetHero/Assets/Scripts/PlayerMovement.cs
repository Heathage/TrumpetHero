using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject[] notes;
    public int note = 6;

    private void Start()
    {
        gameObject.transform.position = notes[note].transform.position;
    }

    public void Update()
    {
        if(Input.GetKeyUp(KeyCode.W))
        {
            note--;
            gameObject.transform.position = notes[note].transform.position;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            note++;
            gameObject.transform.position = notes[note].transform.position;
        }
    }



}

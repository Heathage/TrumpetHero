using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject[] notes;
    [SerializeField]
    private int note = 2;

    private void Start()
    {
        gameObject.transform.position = notes[note].transform.position;
    }

    public void Update()
    {
        if(Input.GetKeyUp(KeyCode.W))
        {
            if (note >= 1)
            {
                note--;
                gameObject.transform.position = notes[note].transform.position;
            }
        }

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

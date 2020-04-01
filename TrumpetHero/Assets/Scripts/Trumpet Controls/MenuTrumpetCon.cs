using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO.Ports;

public class MenuTrumpetCon : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM3", 9600);

    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (sp.IsOpen)
        {
            try
            {
                menuControl(sp.ReadByte());
                print(sp.ReadByte());
            }
            catch (System.Exception)
            {

            }
        }
    }

    public void menuControl(int Valve)
    {
        if (Valve == 1)
        {
            SceneManager.LoadScene(1);
        }

        if (Valve == 2)
        {
            SceneManager.LoadScene(2);
        }
    }

}

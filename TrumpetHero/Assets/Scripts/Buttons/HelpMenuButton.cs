using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpMenuButton : MonoBehaviour
{
    public void HelpMenu()
    {
        SceneManager.LoadScene(2);
    }
}

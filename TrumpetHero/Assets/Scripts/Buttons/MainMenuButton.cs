using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// -----------------------------------------------------------------------------------------------------------
// <copyright file="MainMenuButton.cs">
// MIT Licence Copyright (c) 2020.
// </copyright>
// <author>James Mead Heath</author>
// <summary>
// Loads the main menu when the main menu button is clicked.
// </summary>
// -----------------------------------------------------------------------------------------------------------

public class MainMenuButton : MonoBehaviour
{
    //The main menu is scene zero
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}

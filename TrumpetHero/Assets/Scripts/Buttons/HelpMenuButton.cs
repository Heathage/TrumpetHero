using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// -----------------------------------------------------------------------------------------------------------
// <copyright file="HelpMenuButton.cs">
// MIT Licence Copyright (c) 2020.
// </copyright>
// <author>James Mead Heath</author>
// <summary>
// Loads the help menu when the help menu button is clicked.
// </summary>
// -----------------------------------------------------------------------------------------------------------

public class HelpMenuButton : MonoBehaviour
{
    //The help menu is scene two.
    public void HelpMenu()
    {
        SceneManager.LoadScene(2);
    }
}

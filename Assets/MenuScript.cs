using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public GameObject MainMenu;
    public GameObject ExitMenu;
    public GameObject HelpMenu;
    public GameObject AuthorsMenu;
    public GameObject Guide;


    // MainMenu (4 buttons on/off)

    public void StartGame() // Button Start
    {
        Debug.Log("ButtonStartGameWorks!");
        SceneManager.LoadScene(1);
    }

    public void AreYouSureToQuit() // Button Exit
    {
        MainMenu.SetActive(false);
        ExitMenu.SetActive(true);
        HelpMenu.SetActive(false);
        AuthorsMenu.SetActive(false);
        Guide.SetActive(false);
    }


    public void Help() // Button Help
    {
        Debug.Log("ButtonHelpWorks!");
        MainMenu.SetActive(false);
        ExitMenu.SetActive(false);
        HelpMenu.SetActive(true);
        AuthorsMenu.SetActive(false);
        Guide.SetActive(false);
    }

    public void Authors() // Button Authors
    {
        Debug.Log("ButtonAuthorsWorks!");
        MainMenu.SetActive(false);
        ExitMenu.SetActive(false);
        HelpMenu.SetActive(false);
        AuthorsMenu.SetActive(true);
        Guide.SetActive(false);
    }



    // ExitMenu
    public void Quit() // ButtonQuit
    {
        Debug.Log("ButtonExitWorks!");
        Application.Quit();
    }


    // Back to main menu

    public void BackToMainMenu() // ButtonBack
    {
        MainMenu.SetActive(true);
        ExitMenu.SetActive(false);
        HelpMenu.SetActive(false);
        AuthorsMenu.SetActive(false);
        Guide.SetActive(false);
    }



}

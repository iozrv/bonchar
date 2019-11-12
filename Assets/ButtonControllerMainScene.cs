using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControllerMainScene : MonoBehaviour
{
    public void BackToMenu() // Button Menu
    {
        Debug.Log("ButtonMenuWorks!");
        SceneManager.LoadScene(0);
    }
}

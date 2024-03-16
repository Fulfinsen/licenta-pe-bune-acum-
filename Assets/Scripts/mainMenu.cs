using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void playGame ()
    {
        SceneManager.LoadScene("Level 1");
        Debug.Log("Start!!!");
    }



    public void quit()
    {
        Debug.Log("Quit!!!");
        Application.Quit();
    }
}

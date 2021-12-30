using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationScript : MonoBehaviour
{
    public void GoToIntroScene()
    {
        Application.LoadLevel(0);
    }
    public void GoToMainMenu()
    {
        Application.LoadLevel(1);
    }
    public void GoToGameOverScene()
    {
        Application.LoadLevel(2);
    }
    public void GoToVictoryScene()
    {
        Application.LoadLevel(2);
    }

    public void GoToTutorial()
    {
        Application.LoadLevel(3);
    }

    public void GoToLevel1()
    {
        Application.LoadLevel(5);
    }

    public void GoToBoss1()
    {
        Application.LoadLevel(6);
    }

    public void GoToLevel2()
    {
        Application.LoadLevel(7);
    }

    public void GoToBoss2()
    {
        Application.LoadLevel(8);
    }

    public void Quit()
    {
        Application.Quit();
    }
}

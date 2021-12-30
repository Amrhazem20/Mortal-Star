using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationScript : MonoBehaviour
{
    public void GoToIntroScene()
    {
        Application.LoadLevel(0);
    }
    public void GoToGameScene()
    {
        Application.LoadLevel(1);
    }
    public void GoToGameOverScene()
    {
        Application.LoadLevel(2);
    }
    public void GoToVictoryScene()
    {
        Application.LoadLevel(3);
    }
    public void Quit()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwicthScene : MonoBehaviour
{
    public void GoToMinigameScene()
    {
        //SceneManager.LoadScene("minigame");
        Application.LoadLevel("New Scene");
    }
    public void GoToMinigame1Scene()
    {
        SceneManager.LoadScene("Minigame1");
    }
}

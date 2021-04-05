using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Scene001");
        AnimalNamesQuestionBank.LoadQuestionList();
    }
    public void Load()
    {
        GameControl.control.Load();

        if (!GameControl.scene2Started)
        {
            AnimalNamesQuestionBank.LoadQuestionList();
            SceneManager.LoadScene("Scene001");
        }
        else
        {
            // AnimalFoodQuestionBank.LoadQuestionList();
            SceneManager.LoadScene("Scene002");
        }


    }
}
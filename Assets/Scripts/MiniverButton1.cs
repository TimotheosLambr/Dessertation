using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MiniverButton1 : MonoBehaviour
{
    public void StartButtonClicked()
    {
        SceneManager.LoadScene("SudokuPlay1");
    }

    public void MainMenuButtonClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMyscene : MonoBehaviour
{
    public void ChangeMyScene(string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

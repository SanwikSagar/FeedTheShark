using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startscenemanager : MonoBehaviour
{
    public void startgamescene()
    {
        print("function is working");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

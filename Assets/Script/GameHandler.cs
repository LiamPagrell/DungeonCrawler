using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    public void ChangetoGameScreen()
    {
        SceneManager.LoadScene("game");
    }
}

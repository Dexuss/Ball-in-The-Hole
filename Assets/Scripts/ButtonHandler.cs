using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public void Reload()
    {
        SceneManager.LoadScene("BallGame");
        BallShotController.powerIncrease = 0.11f;
        ScoreController.value = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoleScoreController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            ScoreController.value += 1;
            BallShotController.powerIncrease += 0.02f;
            SceneManager.LoadScene("BallGame");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            if (BestScoreController.value < ScoreController.value)
            {
                BestScoreController.value = ScoreController.value;
            }
            SceneManager.LoadScene("GameOver");
        }
    }
}

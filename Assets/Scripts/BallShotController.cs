using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShotController : MonoBehaviour
{
    private readonly Vector2 startingPosition = new Vector2(-6f, -2.581f);
    private readonly Vector2 gravity = new Vector2(0f, -10f);
    private readonly int dotsNumber = 20;
    [SerializeField]
    private Vector2 velocityVector = new Vector2(7.5f, 13f);
    private float deltaTime = 0.0f;
    [SerializeField]
    private float velocityX = 0.0f;
    [SerializeField]
    private float velocityY = 0.0f;
    private bool clickAllow = true;
    public static float powerIncrease = 0.11f;

    private bool launched = false;
    private Rigidbody2D rigidBody;

    public GameObject parabol;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && clickAllow)
        {
            foreach (var gO in GameObject.FindGameObjectsWithTag("TrajectoryDot"))
            {
                Destroy(gO);
            }

            for (int i = 0; i < dotsNumber; i++)
            {
                 GameObject dotsParabol = Instantiate(parabol);
                 dotsParabol.transform.position = CountDots(deltaTime * i);
            }

            if (velocityX < 7.5f)
            {
                velocityX += powerIncrease;
            }

            if (velocityY < 13f)
            {
                velocityY += powerIncrease;
                deltaTime += 0.005f;
            }

            velocityVector = new Vector2(velocityX, velocityY);

            if (!launched && velocityX >= 7.5f && velocityY >= 13f)
            {
                Launch();
            }
        }

        if (!launched && Input.GetMouseButtonUp(0))
        {
            Launch();
            clickAllow = false;
        }
    }

    private void Launch()
    {
        rigidBody.velocity = velocityVector;
        launched = true;
    }

    private Vector2 CountDots(float elapsedTime)
    {
        return gravity * elapsedTime * elapsedTime * 0.5f + velocityVector * elapsedTime + startingPosition;
    }
}

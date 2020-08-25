using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallControl : MonoBehaviour
{
    public float xInitialForce;
    public float yInitialForce;
    
    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        
        RestartGame();
    }

    private void ResetBall()
    {
        transform.position = Vector2.zero;
        
        _rigidbody2D.velocity = Vector2.zero;
    }

    private void PushBall()
    {
        float yRandomInitialForce = Random.Range(-yInitialForce, yInitialForce);

        float randomDirection = Random.Range(0, 2);

        if (randomDirection < 1)
        {
            _rigidbody2D.AddForce(new Vector2(-xInitialForce, yRandomInitialForce));
        }
        else
        {
            _rigidbody2D.AddForce(new Vector2(xInitialForce, yRandomInitialForce));
        }
    }

    private void RestartGame()
    {
        ResetBall();
        
        Invoke(nameof(PushBall), 2);
    }
}

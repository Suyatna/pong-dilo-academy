using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 10f;
    public float boundaryY = 9f;

    private Rigidbody2D _rigidbody2D;
    private int _score;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = _rigidbody2D.velocity;

        Vector3 position = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            velocity.y = speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            velocity.y = -speed;
        }
        else
        {
            velocity.y = 0;
        }

        _rigidbody2D.velocity = velocity;

        if (position.y > boundaryY)
        {
            position.y = boundaryY;
        }
        else if (position.y < -boundaryY)
        {
            position.y = -boundaryY;
        }

        transform.position = position;
    }

    public void IncrementScore()
    {
        _score++;
    }

    public void ResetScore()
    {
        _score = 0;
    }

    public int Score => _score;
}

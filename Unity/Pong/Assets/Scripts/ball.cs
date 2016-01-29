using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour
{
    Rigidbody2D rigidbody;
    [SerializeField]
    AudioSource palas;


    GameManager gameManager;
    float tiempo;
    [SerializeField]
    private float force;

    // Use this for initialization
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        rigidbody = GetComponent<Rigidbody2D>();
        resetBall();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - tiempo >= 1)
        {
            rigidbody.velocity *= 1.05f;
            tiempo = Time.time;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("right"))
        {
            gameManager.PlayerScores(1);
        }
        else if (collision.gameObject.CompareTag("left"))
        {
            gameManager.PlayerScores(2);
        }
        resetBall();
    }

    private void resetBall()
    {
        transform.position = Vector2.zero;
        rigidbody.velocity = Vector2.zero;

        float x = Random.Range(1f, 3f);
        x *= (Random.Range(0, 2) * 2) - 1;
        float y = Random.Range(3f, -3f);

        Vector2 direction = new Vector2(x, y).normalized;
        rigidbody.AddForce(direction * force);
        tiempo = Time.time;

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("pala"))
        {
            palas.Play();
        }

    }
}

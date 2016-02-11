using UnityEngine;
using System.Collections;
using System;

public class PlayerBot : MonoBehaviour
{
    Rigidbody2D rigid;

    [SerializeField]
    private KeyCode up = KeyCode.UpArrow;
    [SerializeField]
    private KeyCode down = KeyCode.DownArrow;
    [SerializeField]
    private float speed = 10;
    public GameObject Bola { get; set; }
    public static bool botActivo { get; set; }

    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FixedUpdate()
    {
        
        //transform.position = new Vector2(transform.position.x, bola.transform.position.y);
        if (Bola.transform.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.15f);
        }
        if (Bola.transform.position.y < transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.15f);
        }

        
    }

}

using UnityEngine;
using System.Collections;
using System;

public class Player : MonoBehaviour
{
    Rigidbody2D rigid;

    [SerializeField]
    private KeyCode up = KeyCode.Q;
    [SerializeField]
    private KeyCode down = KeyCode.A;
    [SerializeField]
    private float speed = 10;
    [SerializeField]
    private GameObject bola;

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


        Vector2 velocity = Vector2.zero;
        if (Input.GetKey(up))
        {
            velocity.y = speed;
        }
        if (Input.GetKey(down))
        {
            velocity.y = -speed;
        }
        rigid.velocity = velocity;



    }

}

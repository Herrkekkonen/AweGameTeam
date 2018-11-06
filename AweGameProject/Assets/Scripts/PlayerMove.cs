using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{

    public float speed;
    public int playerJumpPower;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        Vector3 movement = new Vector3(moveHorizontal, 0.0f);

        rb.AddForce(movement * speed);
    }
        void Jump()
        {
            //Jumping Code
            GetComponent<Rigidbody>().AddForce(Vector2.up * playerJumpPower);
        }
    }

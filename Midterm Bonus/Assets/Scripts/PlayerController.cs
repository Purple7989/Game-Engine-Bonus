using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int walkSpeed = 5;

    bool isGrounded = true;
    Rigidbody rb;
    public float jump = 5f;
    private float distanceToGround;

    public static PlayerController instance;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        distanceToGround = GetComponent<Collider>().bounds.extents.y;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, -Vector3.up, distanceToGround);
        MoveLeftRight();
        Jump();

    }

    public void MoveLeftRight()
    {
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * walkSpeed, Space.Self);
        }

        if(Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(Vector3.left * Time.deltaTime * walkSpeed, Space.Self);
        }
    }

    public void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (isGrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jump);
                isGrounded = false;
            }
        }
    }
}

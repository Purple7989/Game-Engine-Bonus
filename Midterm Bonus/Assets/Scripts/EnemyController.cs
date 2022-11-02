using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public static EnemyController Einstance;
    public int moveSpeed = 8;
    //Left = false Right = true;
    private bool moveDirection = false;
    private Rigidbody rb;
    public GameObject LeftPosition;
    private Vector3 leftDirection;

    private void Awake()
    {
        if (!Einstance)
        {
            Einstance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        leftDirection = LeftPosition.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveDirection == false)
        {
            // transform.Translate(Vector3.left * Time.deltaTime * moveSpeed, Space.Self);
            rb.AddForce(leftDirection.x, 0.0f, 0.0f);
        }

        if(moveDirection == true)
        {
            //transform.Translate(Vector3.right * Time.deltaTime * moveSpeed, Space.Self);
            rb.velocity = new Vector2(rb.velocity.z, moveSpeed);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Change Direction");
        moveDirection = !moveDirection;

        if(collision.collider.tag == "Player")
        {
            HealthSingleton.instance.ChangeHealth(1);
        }
    }
}

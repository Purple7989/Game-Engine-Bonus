using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public int CubeHealth = 2;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player" && PlayerController.instance.transform.position.y < gameObject.transform.position.y)
        {
            CubeHealth = CubeHealth - 1;
            Debug.Log("Lower Cube Health");
            if (CubeHealth <= 0)
            {
                Destroy(gameObject);
                Debug.Log("DestroyCube");
            }
        }
    }
}

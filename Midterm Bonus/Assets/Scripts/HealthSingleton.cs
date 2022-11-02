using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSingleton : MonoBehaviour
{
    public static HealthSingleton instance;
    int health = 3;
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class HealthSingleton : MonoBehaviour
{
    public static HealthSingleton instance;
    int health = 3;
    public Text healthUIText;
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
        healthUIText.text = health.ToString();
    }

    private void Update()
    {
        if (health <= 0)
        {
            Debug.Log("GameOver");
        }
    }

    public void ChangeHealth(int healthValue)
    {
        health -= healthValue;
        Debug.Log(health);
        healthUIText.text = health.ToString();
    }


}

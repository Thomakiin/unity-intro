using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxer1Script : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (curHealth > maxHealth)
        {
            curHealth = maxHealth;

        }
        if (curHealth <= 0)
        {
            //die
        }
    }

    // Start
    private void Awake()
    { curHealth = maxHealth; }

    // Health
    public int curHealth;
    public int maxHealth;
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public PlayerHealth playerHealth;
    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        string tag = other.gameObject.tag;
        if (tag == "Player")
        {
            playerHealth.currentHealth = 100;

        }
    }

}

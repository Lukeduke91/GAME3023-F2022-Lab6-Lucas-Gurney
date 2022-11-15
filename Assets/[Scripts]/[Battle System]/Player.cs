using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string ID;
    int Health;

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
    
}

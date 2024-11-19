using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Health : MonoBehaviour
{

    public Transform healthBar;
    public int maxHealth = 100;

    private int health;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // public void Healing(int healing)
    // {
    //     health += healing;
    //     health = Mathf.Max(health,0);
    //     health = Mathf.Min(health,maxHealth);
    //     healthBar.localScale = new Vector3((float)health/maxHealth,1,1);

    // }

    public void TakeDamage(int damage){
        health -=damage;
        health = Mathf.Max(health,0);
        health = Mathf.Min(health,maxHealth);

        healthBar.localScale = new Vector3((float)health/maxHealth,1,1);
    }
}

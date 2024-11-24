using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{

    public Transform healthBar;
    public TextMeshProUGUI text;
    public int maxHealth = 100;
    public string player;

    private int health;
    private int score = 0;
    
    private Start scene;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        score = 0;
        scene = GetComponent<Start>();
    }

    // Update is called once per frame
    void Update()
    {
        Death();
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
    private void Death()
    {
            if(health <=0)
            {   
                health += maxHealth;
                text.text = score++.ToString();
                healthBar.localScale = new Vector3((float)health/maxHealth,1,1);
                SceneManager.LoadScene("EndPlayer1");
            }
    }
}

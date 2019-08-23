using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {
    public Image healthBar;
    public static PlayerMovement playerScript;
    public GameObject player;
    public float maxHP;
    public static float newHealth;
    public static float oldHealth;

   // public int barHP = playerScript.playerHP / startingHealth;
   // public int newBarHP = newHealth / startingHealth;

	// Use this for initialization
	void Start () {
        playerScript = player.GetComponent<PlayerMovement>();
        maxHP = playerScript.currentHP;
        newHealth = playerScript.currentHP;
    }
	
	// Update is called once per frame
	void Update () {

        if ((newHealth)  != (playerScript.currentHP))
        {
            healthBar.fillAmount = playerScript.currentHP/maxHP;
            newHealth = playerScript.currentHP;
        }

    }
}

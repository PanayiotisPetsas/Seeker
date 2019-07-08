using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {
    public Image healthBar;
    public static PlayerMovement playerScript;
    public GameObject player;
    public static float startingHealth;
    public static float newHealth;

   // public int barHP = playerScript.playerHP / startingHealth;
   // public int newBarHP = newHealth / startingHealth;

	// Use this for initialization
	void Start () {
        playerScript = player.GetComponent<PlayerMovement>();
        startingHealth = playerScript.playerHP;
        newHealth = playerScript.playerHP;
	}
	
	// Update is called once per frame
	void Update () {
        if ((newHealth)  != (playerScript.playerHP))
        {
            healthBar.fillAmount = playerScript.playerHP/startingHealth;
            newHealth = playerScript.playerHP;
        }

    }
}

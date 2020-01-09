using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthKit : MonoBehaviour
{
    public HealthScript healthScript;
    public GameObject healthBarObject;

    public PlayerMovement playerMovementScript;
    public GameObject player;
    public float maxHealing = 0;
    // Start is called before the first frame update

    void Start()
    {
        maxHealing = 0;
        player = GameObject.FindWithTag("Player");
        playerMovementScript = player.GetComponent<PlayerMovement>();

        healthBarObject = GameObject.Find("HealthBar");
        healthScript = healthBarObject.GetComponent<HealthScript>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "purpleHair1")
        {
            maxHealing = healthScript.maxHP;
            playerMovementScript.currentHP = maxHealing;
            Debug.Log("Max HP achieved at:" + maxHealing);

        }
    }
}

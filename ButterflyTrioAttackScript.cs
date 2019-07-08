using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyTrioAttackScript : MonoBehaviour {

    public GameObject attack;
    public float speed;
    public Vector3 startingPosition;
    public float distanceCovered = 0;
    public PlayerMovement playerScript;
    public GameObject player;

	void Start () {
        // startingPosition = attack.transform.position;
        player = GameObject.FindWithTag("Player");
        playerScript = player.GetComponent<PlayerMovement>();
        player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void FixedUpdate () {
        attack.transform.Translate(0, speed, 0);
        distanceCovered++;

        if(distanceCovered == 15)
        {
            attack.transform.Rotate(0, 0, 45);
        }

        if(distanceCovered == 30)
        {
            Destroy(attack);
        }
	}

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "purpleHair1")
        {
            playerScript.playerHP = playerScript.playerHP - 3;
        }
    }
}

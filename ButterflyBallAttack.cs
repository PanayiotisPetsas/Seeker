using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyBallAttack : MonoBehaviour {
    public GameObject ball;

    public float speed;
    public int distance;
    public PlayerMovement playerScript;
    public GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindWithTag("Player");
        playerScript = player.GetComponent<PlayerMovement>();
        player.GetComponent<PlayerMovement>();
        distance = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        distance++;
        ball.transform.Translate(speed, 0, 0);

        if(distance == 80)
        {
            Destroy(ball);
        }
	}

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "purpleHair1")
        {
            playerScript.playerHP -= 2;
        }
    }
}

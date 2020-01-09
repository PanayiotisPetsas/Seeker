using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterA : MonoBehaviour
{


    //player
    public PlayerMovement playerScript;
    public GameObject player;
    public Vector2 playerPosition;
    public Transform playerTransform;
    //monster
    public GameObject monster;
    public float monsterSpeed = 3;
    public Vector2 monsterPosition;
    private bool lookingLeft = true;
    public float monsterHealth = 5;
    //other
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerScript = player.GetComponent<PlayerMovement>();
        playerTransform = player.GetComponent<Transform>();

        monsterPosition = Vector2.zero;
        playerPosition = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        //distance = Vector2.Distance(playerPosition, monsterPosition);
        distance = ((player.transform.position.x) - (monster.transform.position.x));
        //Debug.Log("distance between the two:" + distance);
        monsterPosition = transform.position;
        playerPosition = player.transform.position;
        if ((distance > 0) && (lookingLeft == true))
        {
            monster.transform.localScale += new Vector3(-2, 0, 0);
            lookingLeft = false;
        }
        else if ((distance < 0) && (lookingLeft == false))
        {
            monster.transform.localScale += new Vector3(2, 0, 0);
            lookingLeft = true;
        }

        //if ((Vector2.Distance(playerPosition, monsterPosition) > 0)
        //DEAD
        if(monsterHealth <= 0)
        {
            Destroy(monster);
        }
    }

    public void ChasePlayer()
    {
        if (Vector2.Distance(playerPosition, monsterPosition) > 0.5f)
        {
            monster.transform.position = Vector2.MoveTowards(monster.transform.position, playerTransform.position, 1.5f * Time.deltaTime);
            print("happening X2");
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "purpleHair1")
        {
            playerScript.currentHP -= 2;
        }
    }
}

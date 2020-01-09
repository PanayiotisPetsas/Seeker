using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeamPrefabShooting : MonoBehaviour
{

    public Rigidbody2D rb;
    public float bulletSpeed;
    public GameObject collidedBullet;
    public GameObject playerObject;
    public PlayerMovement playerMovement;
    public BeamShooting beamShooting;
    public bool straightDirection;
    public GameObject boss;
    public ButterflyBoss bossScript;
    public GameObject beamEffect;

    public MonsterA monsterScript;
    public GameObject monster;

    private int beamDamage = 3;
    public int lastDamage;
    public int newDamage;

    public GameObject effectClone;
    //public Collider2D wall;
    //public Collider2D ofBeamEffect;


    public Scene nameOfCurrentScene;
    public string butterflyScene = "SmallBossArea";
    public string muddyWorldScene = "MuddyWorld";

    public GameObject[] monsters;

    private void Start()
    {

        if (beamDamage != 0)
        {
            beamDamage += newDamage;
        }
        else
        {
            beamDamage = 3;
        }
       // ResetDmg();
        playerObject = GameObject.FindWithTag("Player");
        playerMovement = playerObject.GetComponent<PlayerMovement>();
        playerObject.GetComponent<PlayerMovement>();
        beamShooting = playerObject.GetComponent<BeamShooting>();
        boss = GameObject.FindWithTag("Boss");
        monster = GameObject.FindGameObjectWithTag("Monsters");
        //monsters = GameObject.FindGameObjectsWithTag("Monsters");

        //collidedBullet = beamShooting.beamClone;
        SceneChecker();

        straightDirection = false;

        
        //  Physics2D.IgnoreCollision(wall, ofBeamEffect);

    }
    void Update()
    {

    }

    public void SceneChecker()
    {
        nameOfCurrentScene = SceneManager.GetActiveScene();
        if (nameOfCurrentScene.name == butterflyScene)
        {
            bossScript = boss.GetComponent<ButterflyBoss>();
        }


        nameOfCurrentScene = SceneManager.GetActiveScene();
        print("name of scene is: " + nameOfCurrentScene.name);
        print("name of scene should be: " + muddyWorldScene);
        if (nameOfCurrentScene.name == muddyWorldScene)
        {
            monsterScript = monster.GetComponent<MonsterA>();
            print("name: " + monster.name);

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            //GameObject effectClone = (GameObject)Instantiate(beamEffect, transform.position, transform.rotation);
            Instantiate(beamEffect, transform.position, transform.rotation);
            Destroy(collidedBullet);
            beamShooting.beamIsActive = false;
            straightDirection = false;
            Destroy(collidedBullet);
            effectClone = GameObject.Find("BeamEffect");
            Destroy(effectClone, 1.0f);
            print("Damage:" + beamDamage);
          //  lastDamage = beamDamage;
          //  print("lastDamage:" + lastDamage);

        }
        if (collision.gameObject.tag == "Boss")
        {
            //GameObject effectClone = (GameObject)Instantiate(beamEffect, transform.position, transform.rotation);
            Instantiate(beamEffect, transform.position,transform.rotation);
            Destroy(collidedBullet);
            beamShooting.beamIsActive = false;
            straightDirection = false;
            bossScript.HP -= beamDamage;
            Destroy(collidedBullet);
            effectClone = GameObject.Find("BeamEffect");
            Destroy(effectClone, 1.0f);
        }

        if (collision.gameObject.tag == "Monsters")
        {
            //GameObject effectClone = (GameObject)Instantiate(beamEffect, transform.position, transform.rotation);
            Instantiate(beamEffect, transform.position, transform.rotation);
            Destroy(collidedBullet);
            beamShooting.beamIsActive = false;
            straightDirection = false;
            this.monsterScript.monsterHealth -= beamDamage;
            Destroy(collidedBullet);
            effectClone = GameObject.FindWithTag("Effect");
            Destroy(effectClone, 1.0f);
        }
    }

   // void ResetDmg()
   // {
   //     if (lastDamage != beamDamage)
   //     {
   //         beamDamage = 3;
   //     }
   // }
    public void FixedUpdate()
    {
        if (straightDirection == false)
        {
            if (playerMovement.rightAnim == true)
            {
                rb.velocity = new Vector2(bulletSpeed, 0);
                straightDirection = true;
            }
            if (playerMovement.leftAnim == true)
            {
                rb.velocity = new Vector2(-bulletSpeed, 0);
                straightDirection = true;
            }
            if (playerMovement.upAnim == true)
            {
                rb.velocity = new Vector2(0, bulletSpeed);
                straightDirection = true;
            }
            if (playerMovement.downAnim == true)
            {
                rb.velocity = new Vector2(0, -bulletSpeed);
                straightDirection = true;
            }
        }
    }

}


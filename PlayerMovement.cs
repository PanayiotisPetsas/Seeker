using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {
    public float moreSpeed;
    public float speed = 0.02f;
    public Animator anim;
    public float bulletSpeed;

    public float playerHP = 15;

    public bool upAnim;
    public bool downAnim;
    public bool leftAnim;
    public bool rightAnim;

    public GameObject allOfUI;
    public GameObject portal;
    public GameObject player;
    public GameObject startingPosition;
    public Transform cameraa;
    public Transform playerTransform;

    public void MoreMovement()
    {
        //                          --------------- Extra Speed Movements ----------------


        if (Input.GetKey(KeyCode.UpArrow) && (Input.GetKey(KeyCode.Space)))
        { 
            transform.Translate(0,speed + moreSpeed, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow) && (Input.GetKey(KeyCode.Space)))
        {
            transform.Translate(0,-speed - moreSpeed, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) && (Input.GetKey(KeyCode.Space)))
        {
            transform.Translate(speed + moreSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && (Input.GetKey(KeyCode.Space)))
        {
            transform.Translate(-speed - moreSpeed, 0, 0);
        }
    }
    public void Movement() {
        //                        ---------------Normal Movements---------------
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //  xUp = xUp + speed;
            transform.Translate(0, speed, 0);
            anim.SetBool("Up", true);
            anim.SetBool("Down", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
            upAnim = true;
            downAnim = false;
            leftAnim = false;
            rightAnim = false;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //  xDown = xDown - speed;
            transform.Translate(0, -speed, 0);
            anim.SetBool("Up", false);
            anim.SetBool("Down", true);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
            upAnim = false;
            downAnim = true;
            leftAnim = false;
            rightAnim = false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //  yUp = yUp + speed;
            transform.Translate(speed, 0, 0);
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", true);
            upAnim = false;
            downAnim = false;
            leftAnim = false;
            rightAnim = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //  yDown = yDown - speed;
            transform.Translate(-speed, 0, 0);
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
            anim.SetBool("Left", true);
            anim.SetBool("Right", false);
            upAnim = false;
            downAnim = false;
            leftAnim = true;
            rightAnim = false;
        }
    }

	void Start () {
        anim = GetComponent<Animator>();
        DontDestroyOnLoad(player);
        DontDestroyOnLoad(allOfUI);


    }

    private void FixedUpdate()
    {
        //we always use FixedUpdate for physics (rigidbody2d)
        {

            Movement();
            MoreMovement();
          
        }
    }
    // Update is called once per frame
    void Update () {

	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Portal")
        {
            // anim.SetTrigger("ContactWithPortal");
            SceneManager.LoadScene("SmallBossArea");
            player.transform.position = new Vector2(0.92f, -6.302f); //Starting position;
            player.gameObject.tag.Contains("Player");
            cameraa.transform.parent = playerTransform.parent;
        }
    }
}

 


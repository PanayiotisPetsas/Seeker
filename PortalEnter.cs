using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalEnter : MonoBehaviour {

    public GameObject portal;
    public GameObject player;
    public GameObject startingPosition;
    public Transform cameraa;
    //private Vector2 startPoint;


	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(player);
       // startPoint = new Vector2(0.92f, -6.302f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "purpleHair1")
        {
            SceneManager.LoadScene("SmallBossArea");
            player.transform.position = new Vector2(0.92f, -6.302f); //Starting position;
            cameraa.gameObject.name = "Main Camera";
            player.transform.parent = cameraa.parent;
        }
    }
}

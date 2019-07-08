using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleWalkingScript : MonoBehaviour {

    public GameObject trail;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerStay2D(Collider2D coll)
    {
        if(coll.gameObject.name == "purpleHair1")
        {
            trail.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.name == "purpleHair1")
        {
            trail.gameObject.SetActive(false);
        }
    }
}

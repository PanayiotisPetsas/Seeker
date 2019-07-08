using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamPickUp : MonoBehaviour {
   public Object Player;
   public Object pickUpBeam;
    public int itemCount;
    public GameObject portal;
    public bool pickedUp = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        afterDestroyed();

    }
    void OnCollisionEnter2D(Collision2D Player)
    {
        if (Player.gameObject.tag == "Beam" )
        {
            Destroy(pickUpBeam);
            itemCount++;
            print("Item count = " + itemCount);
            portal.SetActive(true);
            pickedUp = true;
            
        }
    }

    void afterDestroyed()
    {
     /*   if (pickUpBeam = pickUpBeam)
        {
            print("not destroyed");
        }
        else
        {
            print("destroyed");
        }

    */}  
}

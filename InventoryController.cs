using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InventoryController : MonoBehaviour {
    //This is the inventory of the player

    public Inventory[] playerInventory;
    public int[] Size;
    public GameObject[] Items = new GameObject[5];

    void Start () {

    }

    // Update is called once per frame
    void Update () {
		
	}

    
    public class Inventory
    {
    public int uniqueNum;
    public GameObject item;
            
        
    }
}

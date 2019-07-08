using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPositionClicked : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        print("clicked!");

    }
    private void OnMouseDrag()
    {
        print("about to change positions!");
    }
}

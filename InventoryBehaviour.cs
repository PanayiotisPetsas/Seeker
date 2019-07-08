using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBehaviour : MonoBehaviour {
    public GameObject Background;
        bool gameIsPaused = false;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        BGpopUp();
	}
    public void BGpopUp()
    {
        if (Input.GetKeyDown(KeyCode.Z) && ( gameIsPaused == false))
        {

            gameIsPaused = true;
            Time.timeScale = 0.0f;
            Background.gameObject.SetActive(true);

        }
        else if (Input.GetKeyDown(KeyCode.Z) && (gameIsPaused == true))
        {
            Time.timeScale = 1.0f;
            Background.gameObject.SetActive(false);
            gameIsPaused = false;
        }
        
        if(gameIsPaused == true)
        {

            Time.timeScale = 0.0f;
        }
    }
            
           
 }


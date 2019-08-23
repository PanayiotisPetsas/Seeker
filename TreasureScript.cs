using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureScript : MonoBehaviour
{
    public GameObject treasure;
    public GameObject treasureOptions;
    public BeamPrefabShooting beamPrefabShootingScript;

    public GameObject player;
    public PlayerMovement playerMovementScript;

    public GameObject beam;
    public BeamShooting beamShootingScript;

    public GameObject portalForMuddyWorld;
    // Start is called before the first frame update
    void Start()
    {
        portalForMuddyWorld.SetActive(false);
        treasureOptions.SetActive(false);
        player = GameObject.FindWithTag("Player");
        playerMovementScript = player.GetComponent<PlayerMovement>();
        beamPrefabShootingScript = GetComponent<BeamPrefabShooting>();
        beamShootingScript = GetComponent<BeamShooting>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChooseOptionA()
    {
        playerMovementScript.currentHP += 25;
        Destroy(treasure);
        treasureOptions.SetActive(false);
        portalForMuddyWorld.SetActive(true);
        Time.timeScale = 1.0f;
    }

    public void ChooseOptionB()
    {
        playerMovementScript.speed += 0.01f;
        beamShootingScript = beam.GetComponent<BeamShooting>();
        beamPrefabShootingScript = beam.GetComponent<BeamPrefabShooting>();
        beamPrefabShootingScript.newDamage = 5;
        Destroy(treasure);
        treasureOptions.SetActive(false);
        portalForMuddyWorld.SetActive(true);
        Time.timeScale = 1.0f;

    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "purpleHair1")
        {
            treasureOptions.SetActive(true);
            Time.timeScale = 0.0f;

        }
    }
}

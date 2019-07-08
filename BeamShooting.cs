using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamShooting : MonoBehaviour
{
    public GameObject destroyedBeam;
    public GameObject beam;
    public GameObject beamClone;

    public Transform bulletSpawnRight;
    public Transform bulletSpawnLeft;
    public Transform bulletSpawnUp;
    public Transform bulletSpawnDown;
    public PlayerMovement playerMovement;
    public bool beamIsActive;
    public bool beamActiveForSeconds;

    private void Start()
    {
        beamActiveForSeconds = false;
        playerMovement.GetComponent<PlayerMovement>();
    }


    void Update()
    {
        BeamShoot();
    }

    public void BeamShoot()
    {
        if (beamIsActive == false)
        {
            if (destroyedBeam = destroyedBeam)
            {
            }
            else
            {

                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (playerMovement.rightAnim == true)
                    {
                        //Instantiate(beam, bulletSpawnRight.transform);
                        beamClone = (GameObject)Instantiate(beam, bulletSpawnRight.transform);
                        beamIsActive = true;
                        //StartCoroutine(Wait());
                    }
                    if (playerMovement.leftAnim == true)
                    {
                        //Instantiate(beam, bulletSpawnLeft.transform);
                        beamClone = (GameObject)Instantiate(beam, bulletSpawnLeft.transform);
                        beamIsActive = true;
                        //StartCoroutine(Wait());
                    }
                    if (playerMovement.upAnim == true)
                    {
                        //Instantiate(beam, bulletSpawnUp.transform);
                        beamClone = (GameObject)Instantiate(beam, bulletSpawnUp.transform);
                        beamIsActive = true;
                        //StartCoroutine(Wait());
                    }
                    if (playerMovement.downAnim == true)
                    {
                        //Instantiate(beam, bulletSpawnDown.transform);
                        beamClone = (GameObject)Instantiate(beam, bulletSpawnDown.transform);
                        beamIsActive = true;
                        //StartCoroutine(Wait());
                    }

                }
            }

        }
     //   if (beamIsActive == true)
     //   {
     //       Destroy(beamClone, 1.0f);
     //       beamIsActive = false;
     //       StartCoroutine(Wait());
     //       beamActiveForSeconds = false;
     //   }
    }
    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(1.0f);
        beamActiveForSeconds = true;
    }
}

 